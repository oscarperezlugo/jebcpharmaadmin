using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PanelAdmin
{
    public partial class ProductoClienteB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = GridView3.SelectedIndex;
            string nombre = GridView3.Rows[i].Cells[2].Text;
            //string apellido = GridView1.Rows[i].Cells[1].Text;
            //string correo = GridView1.Rows[i].Cells[2].Text;
            //string telefono = GridView1.Rows[i].Cells[3].Text;
            //string direccion = GridView1.Rows[i].Cells[4].Text;
            //string fecha = GridView1.Rows[i].Cells[5].Text;
            //string id = GridView1.Rows[i].Cells[6].Text;
            HttpCookie nombreS = new HttpCookie("nombreRowC");
            nombreS.Value = nombre;
            nombreS.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(nombreS);
            //HttpCookie apellidoS = new HttpCookie("apellidoC");
            //apellidoS.Value = apellido;
            //apellidoS.Expires = DateTime.Now.AddDays(1);
            //Response.Cookies.Add(apellidoS);
            //HttpCookie correoS = new HttpCookie("correoC");
            //correoS.Value = correo;
            //correoS.Expires = DateTime.Now.AddDays(1);
            //Response.Cookies.Add(correoS);
            //HttpCookie telefonoS = new HttpCookie("telefonoC");
            //telefonoS.Value = telefono;
            //telefonoS.Expires = DateTime.Now.AddDays(1);
            //Response.Cookies.Add(telefonoS);
            //HttpCookie direccionS = new HttpCookie("direccionC");
            //direccionS.Value = direccion;
            //direccionS.Expires = DateTime.Now.AddDays(1);
            //Response.Cookies.Add(direccionS);
            //HttpCookie fechaS = new HttpCookie("fechaC");
            //fechaS.Value = fecha;
            //fechaS.Expires = DateTime.Now.AddDays(1);
            //Response.Cookies.Add(fechaS);
            //HttpCookie idS = new HttpCookie("idC");
            //idS.Value = id;
            //idS.Expires = DateTime.Now.AddDays(1);
            //Response.Cookies.Add(idS);
            string connectionString = Conection.ConexLine;
            string query = "SELECT  iDCliente, iDVenta FROM Cabecera where Row = " + nombre + "";


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
                            Guid clienn = dr.GetFieldValue<Guid>(0);
                            HttpCookie index2S7 = new HttpCookie("idclienteP");
                            index2S7.Value = clienn.ToString();
                            index2S7.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(index2S7);

                            Guid venta = dr.GetFieldValue<Guid>(1);
                            HttpCookie index2S72 = new HttpCookie("idventaP");
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
            Response.Redirect("PedidoDetalle.aspx");
        }
    }
}