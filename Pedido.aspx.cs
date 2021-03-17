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
    public partial class Pedido : System.Web.UI.Page
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
            HttpCookie index2S1 = new HttpCookie("obser1C");
            index2S1.Value = Nombre.Value;
            index2S1.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(index2S1);
            HttpCookie index2S2 = new HttpCookie("obser2C");
            index2S2.Value = Text1.Value;
            index2S2.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(index2S2);
            HttpCookie index2S3 = new HttpCookie("obser3C");
            index2S3.Value = Text2.Value;
            index2S3.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(index2S3);
            using (SqlConnection openCon = new SqlConnection("workstation id=jebcpharma.mssql.somee.com;packet size=4096;user id=paladar_SQLLogin_1;pwd=bgofrm6416;data source=jebcpharma.mssql.somee.com;persist security info=False;initial catalog=jebcpharma"))
            {
                string saveStaff = "INSERT into Cabecera (FechaVenta, iDVenta, Tipo, Status, TipoVenta, Vendedor) VALUES (@FechaVenta, @iDVenta, @Tipo, 'PAGO POR VERIFICAR', @TipoVenta, @Vendedor)";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Now;
                    querySaveStaff.Parameters.Add("@iDVenta", SqlDbType.UniqueIdentifier).Value = GUID;
                    querySaveStaff.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = DropDownList3.SelectedValue;
                    querySaveStaff.Parameters.Add("@TipoVenta", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                    querySaveStaff.Parameters.Add("@Vendedor", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;

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
                Response.Redirect("PedidoDos.aspx");
            }
        }
    }
}