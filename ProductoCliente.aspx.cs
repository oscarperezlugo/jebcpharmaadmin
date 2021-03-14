using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PanelAdmin
{
    public partial class ProductoCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
    }
}