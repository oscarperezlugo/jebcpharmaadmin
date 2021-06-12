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
    public partial class CotizacionTotal : System.Web.UI.Page
    {
        string VENTA;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = "OBSERVACIONES: "+Request.Cookies["observC"].Value+"";
            VENTA = Request.Cookies["idventaC"].Value;
            string connectionString = "workstation id=jebcpharma.mssql.somee.com;packet size=4096;user id=paladar_SQLLogin_1;pwd=bgofrm6416;data source=jebcpharma.mssql.somee.com;persist security info=False;initial catalog=jebcpharma";
            string query = "SELECT Row FROM Cabecera WHERE iDVenta=@Correo";


            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {

                cmd.Parameters.Add("@Correo", SqlDbType.VarChar, 50).Value = VENTA;
                


                con.Open();


                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        int nombre = dr.GetFieldValue<int>(0);
                        Label1.Text = "     #"+nombre.ToString()+"";



                    }
                    else
                    {
                       

                    }

                    dr.Close();
                }

                con.Close();
            }

        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Session["ctrl"] = pnl1;
            Response.Cookies["observC"].Expires = DateTime.Now.AddDays(-1);
            ClientScript.RegisterStartupScript(this.GetType(), "onclick", "<script language=javascript>window.open('Print.aspx','PrintMe','height=600px,width=600px,scrollbars=1');</script>");
        }
    }
}