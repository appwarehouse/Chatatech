using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using System.Web.Http.Dispatcher;

public class APIKeyMessageHandler : DelegatingHandler
{
    const string PublicKey = "A73D1BD977A73E28337368F9DB494";

    public APIKeyMessageHandler(HttpConfiguration config)
    {
        
        InnerHandler = new HttpControllerDispatcher(config);
    }


    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage httpRequestMessage, CancellationToken cancellationToken)
    {
        bool validKey = false;
        IEnumerable<string> requestHeaders;
        var checkApiKeyExists = httpRequestMessage.Headers.TryGetValues("APIKey", out requestHeaders);

        if (checkApiKeyExists)
        {
            if (requestHeaders.FirstOrDefault().Equals(PublicKey))
                validKey = true;
        }

        if (!validKey)
            return httpRequestMessage.CreateResponse(HttpStatusCode.Forbidden, "Invalid Key");

        var response = await base.SendAsync(httpRequestMessage, cancellationToken);
        return response;
    }
}
