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
    public partial class Lista : System.Web.UI.Page
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
            string rif = GridView1.Rows[i].Cells[7].Text;
            string sicm = GridView1.Rows[i].Cells[8].Text;
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
            HttpCookie id2S = new HttpCookie("rifC");
            id2S.Value = rif;
            id2S.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(id2S);
            HttpCookie id23S = new HttpCookie("indexC");
            id23S.Value = "2";
            id23S.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(id23S);
            HttpCookie id235S = new HttpCookie("sicmC");
            id235S.Value = sicm;
            id235S.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(id235S);
            Response.Redirect("ClienteEdicion.aspx");
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string buscar = Correo.Value;
            HttpCookie buscarS = new HttpCookie("paramcincoC");
            buscarS.Value = buscar;
            buscarS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(buscarS);
            Response.Redirect("Lista.aspx");
        }
        protected void descarga1(object sender, EventArgs e)
        {
            string connectionString2 = Conection.ConexLine;
            string query2 = "SELECT * FROM Clientes WHERE Tipo = 'CLIENTE' ";


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
                                Response.AddHeader("content-disposition", "attachment;filename=ReporteClientes.xlsx");
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