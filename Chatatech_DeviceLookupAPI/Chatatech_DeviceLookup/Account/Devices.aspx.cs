using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Chatatech_DeviceLookup.Models;
using Newtonsoft.Json;
using Syncfusion.JavaScript.Web;

namespace Chatatech_DeviceLookup.Account
{
    public partial class Devices : System.Web.UI.Page
    {
        DataTable dt = new DataTable("Devices");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection myConnection =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
                dt = new DataTable("Devices");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = myConnection;
                cmd.CommandText = @" SELECT d.Id, d.SerialMatch, d.YearOfManufacture, d.OriginalCost, d.Model, d.Discontinued, r.Model AS 'Replacement', b.Name AS Manufacturer, n.Name AS 'Product Name', n.Size, t.Name AS Type
                                    FROM DeviceMatchings AS d INNER JOIN
                                    DeviceManufacturers AS b ON d.DeviceBrand_Id = b.Id INNER JOIN
                                    DeviceNames AS n ON d.DeviceName_Id = n.Id AND b.Id = n.DeviceManufacturer_Id INNER JOIN
                                    DeviceTypes AS t ON d.DeviceType_Id = t.Id AND n.DeviceType_Id = t.Id INNER JOIN
                                    DeviceMatchings AS r ON d.ReplacementDevice_Id = r.Id";
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                if (myConnection.State == ConnectionState.Closed)
                {
                    myConnection.Open();
                }
                da.Fill(dt);
                Session["SqlDataSource"] = dt;
                dataBind();
            }

        }

        protected void dataBind()
        {
            gridDevices.DataSource = (DataTable)Session["SqlDataSource"];
            gridDevices.DataBind();

        }

        protected void gridManufacturers_EditRow(object sender, GridEventArgs e)
        {
            EditAction(e.EventType, e.Arguments["data"]);

        }

        protected void gridManufacturers_AddRow(object sender, GridEventArgs e)
        {
            EditAction(e.EventType, e.Arguments["data"]);
        }

        protected void EditEvents_ServerDeleteRow(object sender, GridEventArgs e)
        {
            EditAction(e.EventType, e.Arguments["data"]);
        }

        protected void EditAction(string eventType, object record)
        {
            DeviceContext context = new DeviceContext();
            dt = Session["SqlDataSource"] as DataTable;
            string recObj = JsonConvert.SerializeObject(record);
            if (eventType == "endEdit")
            {
                DeviceManufacturer newMan = JsonConvert.DeserializeObject<DeviceManufacturer>(recObj);
                DeviceManufacturer deviceMan = context.DeviceManufacturers
                    .Single(c => c.Id == newMan.Id);

                deviceMan.Name = newMan.Name;
                deviceMan.Description = newMan.Description;
                deviceMan.Active = newMan.Active;

                context.SaveChanges();

                DataRow[] dr = dt.Select("Id = " + newMan.Id);

                dr[0]["Name"] = newMan.Name;
                dr[0]["Description"] = newMan.Description;
                dr[0]["Active"] = newMan.Active;
            }
            else if (eventType == "endAdd")
            {
                //var Order = KeyVal.Values.ToArray();
                //DataRow dr = dt.NewRow();
                //dr["OrderID"] = Order[0];
                //dr["EmployeeID"] = Order[1];
                //dr["Freight"] = Order[2];
                //dr["ShipCity"] = Order[3];
                //dr["ShipCountry"] = Order[4];
                //dt.Rows.Add(dr);
            }

            Session["SqlDataSource"] = dt;
            dataBind();
        }
    }
}