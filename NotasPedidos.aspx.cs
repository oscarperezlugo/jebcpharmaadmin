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
    public partial class NotasPedidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string connectionString = Conection.ConexLine;
            string query = "SELECT  IDCliente, iDVenta FROM Cabecera where Row = "+DropDownList2.SelectedValue+"";


            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {

                con.Open();


                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    if (dr.Read())
                    {
                        if (dr.IsDBNull(0))
                        {

                            

                        }
                        else
                        {
                            Guid nombre = dr.GetFieldValue<Guid>(0);
                            HttpCookie index2S7 = new HttpCookie("clienR");
                            index2S7.Value = nombre.ToString();
                            index2S7.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(index2S7);

                            Guid venta = dr.GetFieldValue<Guid>(1);
                            HttpCookie index2S72 = new HttpCookie("ventaR");
                            index2S72.Value = venta.ToString();
                            index2S72.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(index2S72);

                        }


                    }
                    else
                    {
                        

                    }



                    dr.Close();
                }

                con.Close();
            }
            HttpCookie index2S = new HttpCookie("notaR");
            index2S.Value = DropDownList2.SelectedValue;
            index2S.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(index2S);
            
            Response.Redirect("ProductoClienteB.aspx");
            
        }
    }
}