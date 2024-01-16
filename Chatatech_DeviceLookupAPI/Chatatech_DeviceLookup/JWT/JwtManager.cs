using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Chatatech_DeviceLookup.Models
{
    
    public static class JwtManager
    {
        /// <summary>
        // Use the below code to generate symmetric Secret Key
             //var hmac = new HMACSHA256();
             //var key = Convert.ToBase64String(hmac.Key);
        
        private const string Secret = "bzgoXMf6hgjkd6PTztYTs6tMiSYcw2tgJ+amz8ieHAggGTM06sq/0/3ypJTG76Qa8lVcRqPCe8sOLxsqutMkUA==";
        
        public static string GenerateToken(string username, int expireMinutes = (24*60))
        {
           //var hmac = new HMACSHA256();
            //var key = Convert.ToBase64String(hmac.Key);

           
            var symmetricKey = Convert.FromBase64String(Secret);
            var tokenHandler = new JwtSecurityTokenHandler();

            var now = DateTime.UtcNow;
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                        {
                            new Claim(ClaimTypes.Name, username)
                        }),

                Expires = now.AddMinutes(Convert.ToInt32(expireMinutes)),

                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(symmetricKey), SecurityAlgorithms.HmacSha256Signature)
            };

            var stoken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(stoken);

            return token;
        }


        public static bool VerifySignature(string token)
        {
           
            var jwtToken = new JwtSecurityToken(token);
            string jwt = token;
            string[] parts = jwt.Split(".".ToCharArray());
            var header = jwtToken.RawHeader; //parts[0];
            var payload = jwtToken.RawPayload; // parts[1];
            var signature = jwtToken.RawSignature; // parts[2];//Base64UrlEncoded signature from the token

            byte[] bytesToSign = getBytes(string.Join(".", header, payload));

            byte[] secret = Convert.FromBase64String(Secret);

            var alg = new HMACSHA256(secret);
            var hash = alg.ComputeHash(bytesToSign);

            var computedSignature = Base64UrlEncode(hash);

            if (signature == computedSignature)
            {
                //check time validity

                if (jwtToken.ValidTo <= DateTime.Now)
                    return false;

                return true;
            }
            else
            {
                return false;
            }
        }

        private static byte[] getBytes(string value)
        {
            return Encoding.UTF8.GetBytes(value);
        }

        // from JWT spec
        private static string Base64UrlEncode(byte[] input)
        {
            var output = Convert.ToBase64String(input);
            output = output.Split('=')[0]; // Remove any trailing '='s
            output = output.Replace('+', '-'); // 62nd char of encoding
            output = output.Replace('/', '_'); // 63rd char of encoding
            return output;
        }

        public static ClaimsPrincipal GetPrincipal(string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                
                var jwtToken = tokenHandler.ReadToken(token) as JwtSecurityToken;

                if (jwtToken == null)
                    return null;

                var symmetricKey = Convert.FromBase64String(Secret);

                var validationParameters = new TokenValidationParameters()
                {
                    RequireExpirationTime = true,
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    IssuerSigningKey = new SymmetricSecurityKey(symmetricKey)
                };

                SecurityToken securityToken;

                
                var valid = jwtToken.ValidTo;
                if (valid > DateTime.UtcNow.AddMinutes(1))
                {
                    var principal = tokenHandler.ValidateToken(token,
                    validationParameters, out securityToken);

                    return principal;
                }
                else
                {
                    return null;
                }
                    
            }

            catch (Exception ex)
            {
                return null;
            }
        }
    }
}