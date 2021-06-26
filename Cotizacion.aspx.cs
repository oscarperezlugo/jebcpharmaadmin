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
            HttpCookie index2S5 = new HttpCookie("observC");
            index2S5.Value = Nombre.Value;
            index2S5.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(index2S5);
            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
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