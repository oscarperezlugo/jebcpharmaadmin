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
            if (Request.Cookies["observC"] == null)
            {
                
            }
            else
            {
                Label2.Text = "OBSERVACIONES: " + Request.Cookies["observC"].Value + "";
                Response.Cookies["observC"].Expires = DateTime.Now.AddDays(-1);
            }
           
            VENTA = Request.Cookies["idventaC"].Value;
            string connectionString = Conection.ConexLine;
            string query = "SELECT Row, Monto, MontoD FROM Cabecera WHERE iDVenta=@Correo";


            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {

                cmd.Parameters.Add("@Correo", SqlDbType.VarChar).Value = Guid.Parse(VENTA).ToString();



                con.Open();


                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        int nombre = dr.GetFieldValue<int>(0);
                        Label1.Text = "# " + nombre.ToString() + "";
                        string monto = dr.GetFieldValue<Decimal>(1).ToString("#,#");
                        string montod = dr.GetFieldValue<Decimal>(2).ToString("#,#");                        
                        GridView3.FooterRow.Cells[2].Text = monto;
                        GridView3.FooterRow.Cells[1].Text = "TOTAL:";
                        GridView3.FooterRow.Cells[0].Text = "TOTAL GENERAL $: " + montod + "";



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