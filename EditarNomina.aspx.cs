using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PanelAdmin
{
    public partial class EditarNomina : System.Web.UI.Page
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
            if (GridView1.SelectedIndex >= 0)
            {
                int i = GridView1.SelectedIndex;
                string nombre = GridView1.Rows[i].Cells[0].Text;
                string apellido = GridView1.Rows[i].Cells[1].Text;
                string correo = GridView1.Rows[i].Cells[2].Text;
                //string correo = GridView1.Rows[i].Cells[2].Text;
                string telefono = GridView1.Rows[i].Cells[3].Text;
                string direccion = GridView1.Rows[i].Cells[4].Text;
                //string vendedor = GridView1.Rows[i].Cells[4].Text; //
                string row = GridView1.Rows[i].Cells[5].Text;
                string rif = GridView1.Rows[i].Cells[6].Text;
                //string sicm = GridView1.Rows[i].Cells[7].Text;
                string tel2 = GridView1.Rows[i].Cells[7].Text;
                //string tipo = GridView1.Rows[i].Cells[9].Text; //
                string pers = GridView1.Rows[i].Cells[8].Text;  // 
                string sueldo = GridView1.Rows[i].Cells[9].Text;
                string tipo = GridView1.Rows[i].Cells[10].Text;
                HttpCookie nombreS = new HttpCookie("nombreNomC");
                nombreS.Value = nombre;
                nombreS.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(nombreS);
                HttpCookie apellidoS = new HttpCookie("tel2C");
                apellidoS.Value = tel2;
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
                HttpCookie fechaS = new HttpCookie("apellidoC");
                fechaS.Value = apellido;
                fechaS.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(fechaS);
                HttpCookie idS = new HttpCookie("rowC");
                idS.Value = row;
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
                HttpCookie id235S = new HttpCookie("sueldoC");
                id235S.Value = sueldo;
                id235S.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(id235S);
                HttpCookie id23St = new HttpCookie("tipoC");
                id23St.Value = tipo;
                id23St.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(id23St);
                HttpCookie id235Sy = new HttpCookie("persC");
                id235Sy.Value = pers;
                id235Sy.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(id235Sy);
                Response.Redirect("NominaEditar.aspx");
            }
            else
            {
                int i = GridView2.SelectedIndex;
                string nombre = GridView2.Rows[i].Cells[0].Text;
                string apellido = GridView2.Rows[i].Cells[1].Text;
                string correo = GridView1.Rows[i].Cells[2].Text;
                //string correo = GridView1.Rows[i].Cells[2].Text;
                string telefono = GridView2.Rows[i].Cells[3].Text;
                string direccion = GridView2.Rows[i].Cells[4].Text;
                //string vendedor = GridView1.Rows[i].Cells[4].Text; //
                string row = GridView2.Rows[i].Cells[5].Text;
                string rif = GridView2.Rows[i].Cells[6].Text;
                //string sicm = GridView1.Rows[i].Cells[7].Text;
                string tel2 = GridView2.Rows[i].Cells[7].Text;
                //string tipo = GridView1.Rows[i].Cells[9].Text; //
                string pers = GridView2.Rows[i].Cells[8].Text;  // 
                string sueldo = GridView2.Rows[i].Cells[9].Text;
                string tipo = GridView2.Rows[i].Cells[10].Text;
                HttpCookie nombreS = new HttpCookie("nombreNomC");
                nombreS.Value = nombre;
                nombreS.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(nombreS);
                HttpCookie apellidoS = new HttpCookie("tel2C");
                apellidoS.Value = tel2;
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
                HttpCookie fechaS = new HttpCookie("apellidoC");
                fechaS.Value = apellido;
                fechaS.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(fechaS);
                HttpCookie idS = new HttpCookie("rowC");
                idS.Value = row;
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
                HttpCookie id235S = new HttpCookie("sueldoC");
                id235S.Value = sueldo;
                id235S.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(id235S);
                HttpCookie id23St = new HttpCookie("tipoC");
                id23St.Value = tipo;
                id23St.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(id23St);
                HttpCookie id235Sy = new HttpCookie("persC");
                id235Sy.Value = pers;
                id235Sy.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(id235Sy);
                Response.Redirect("NominaEditar.aspx");
            }

            
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string buscar = Correo.Value;
            HttpCookie buscarS = new HttpCookie("paramcincoC");
            buscarS.Value = buscar;
            buscarS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(buscarS);
            Response.Redirect("EditarNomina.aspx");
        }
    }
}