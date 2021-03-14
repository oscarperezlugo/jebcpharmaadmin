using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PanelAdmin
{
    public partial class Cotizacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            System.Guid GUID = System.Guid.NewGuid();
            HttpCookie indexS = new HttpCookie("clienteC");
            indexS.Value = DropDownList1.SelectedValue;
            indexS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(indexS);
            HttpCookie index2S = new HttpCookie("idventaC");
            index2S.Value = GUID.ToString();
            index2S.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(index2S);
            using (SqlConnection openCon = new SqlConnection("workstation id=jebcpharma.mssql.somee.com;packet size=4096;user id=paladar_SQLLogin_1;pwd=bgofrm6416;data source=jebcpharma.mssql.somee.com;persist security info=False;initial catalog=jebcpharma"))
            {
                string saveStaff = "INSERT into Cabecera (FechaVenta, iDVenta, Tipo) VALUES (@FechaVenta, @iDVenta, @Tipo)";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Now;
                    querySaveStaff.Parameters.Add("@iDVenta", SqlDbType.UniqueIdentifier).Value = GUID;
                    querySaveStaff.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = "COTIZACION";

                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
                    }
                    catch (SqlException ex)
                    {
                        Response.Write("Error" + ex);
                    }
                }
                Response.Redirect("CotizacionDos.aspx");
            }
        }
    }
}