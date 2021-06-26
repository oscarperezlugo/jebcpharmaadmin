using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PanelAdmin
{
    public partial class ListaProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (GridView2.Rows.Count > 0)
            {
                GridView1.Attributes.Add("style", "display:none");
            }
            else
            {
                GridView2.Attributes.Add("style", "display:none");
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = GridView1.SelectedIndex;
            string nombre = GridView1.Rows[i].Cells[0].Text;
            string apellido = GridView1.Rows[i].Cells[1].Text;
            string correo = GridView1.Rows[i].Cells[2].Text;
            string telefono = GridView1.Rows[i].Cells[3].Text;
            string direccion = GridView1.Rows[i].Cells[4].Text;
            string fecha = GridView1.Rows[i].Cells[5].Text;
            string id = GridView1.Rows[i].Cells[6].Text;
            HttpCookie nombreS = new HttpCookie("nombreC");
            nombreS.Value = nombre;
            nombreS.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(nombreS);
            HttpCookie apellidoS = new HttpCookie("apellidoC");
            apellidoS.Value = apellido;
            apellidoS.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(apellidoS);
            HttpCookie correoS = new HttpCookie("correoC");
            correoS.Value = correo;
            correoS.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(correoS);
            HttpCookie telefonoS = new HttpCookie("telefonoC");
            telefonoS.Value = telefono;
            telefonoS.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(telefonoS);
            HttpCookie direccionS = new HttpCookie("direccionC");
            direccionS.Value = direccion;
            direccionS.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(direccionS);
            HttpCookie fechaS = new HttpCookie("fechaC");
            fechaS.Value = fecha;
            fechaS.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(fechaS);
            HttpCookie idS = new HttpCookie("idC");
            idS.Value = id;
            idS.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(idS);
            Response.Redirect("ClienteEdicion.aspx");
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string buscar = Correo.Value;
            HttpCookie buscarS = new HttpCookie("paramseisC");
            buscarS.Value = buscar;
            buscarS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(buscarS);
            Response.Redirect("ListaProductos.aspx");
        }
        protected void descarga1(object sender, EventArgs e)
        {
            string connectionString2 = Conection.ConexLine;
            string query2 = "SELECT Producto, Precio, PrecioD, Lote, FechaVenc, Codigo, Cantidad FROM Producto";


            using (SqlConnection con2 = new SqlConnection(connectionString2))
            using (SqlCommand cmd2 = new SqlCommand(query2, con2))
            using (SqlDataAdapter sda2 = new SqlDataAdapter())
            using (DataTable dt2 = new DataTable())
            {


                sda2.SelectCommand = cmd2;
                sda2.Fill(dt2);
                con2.Open();


                using (SqlDataReader dr2 = cmd2.ExecuteReader())
                {

                    if (dr2.Read())
                    {
                        if (dr2.IsDBNull(0))
                        {



                        }
                        else
                        {
                            using (XLWorkbook wb = new XLWorkbook())
                            {
                                wb.Worksheets.Add(dt2, "Reporte");

                                Response.Clear();
                                Response.Buffer = true;
                                Response.Charset = "";
                                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                                Response.AddHeader("content-disposition", "attachment;filename=ReporteProductos.xlsx");
                                using (MemoryStream MyMemoryStream = new MemoryStream())
                                {
                                    wb.SaveAs(MyMemoryStream);
                                    MyMemoryStream.WriteTo(Response.OutputStream);
                                    Response.Flush();
                                    Response.End();
                                }
                            }





                        }


                    }
                    else
                    {



                    }



                    dr2.Close();
                }

                con2.Close();
            }



        }
    }
}