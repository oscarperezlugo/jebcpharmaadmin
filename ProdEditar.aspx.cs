using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PanelAdmin
{
    public partial class ProdEditar : System.Web.UI.Page
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
            if(GridView1.SelectedIndex >= 0)
            {
                int i = GridView1.SelectedIndex;
                string producto = GridView1.Rows[i].Cells[0].Text;
                string precio = GridView1.Rows[i].Cells[1].Text;
                string row = GridView1.Rows[i].Cells[2].Text;
                string preciod = GridView1.Rows[i].Cells[3].Text;
                string categoria = GridView1.Rows[i].Cells[4].Text;
                string cantidad = GridView1.Rows[i].Cells[5].Text;
                string impuesto = GridView1.Rows[i].Cells[6].Text;
                string precioc = GridView1.Rows[i].Cells[7].Text;
                string lote = GridView1.Rows[i].Cells[8].Text;
                string fecha = GridView1.Rows[i].Cells[9].Text;
                string unidad = GridView1.Rows[i].Cells[10].Text;
                HttpCookie nombreS = new HttpCookie("productoC");
                nombreS.Value = producto;
                nombreS.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(nombreS);
                HttpCookie apellidoS = new HttpCookie("precioC");
                apellidoS.Value = precio;
                apellidoS.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(apellidoS);
                HttpCookie correoS = new HttpCookie("rowC");
                correoS.Value = row;
                correoS.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(correoS);
                HttpCookie telefonoS = new HttpCookie("preciodC");
                telefonoS.Value = preciod;
                telefonoS.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(telefonoS);
                HttpCookie direccionS = new HttpCookie("categoriaC");
                direccionS.Value = categoria;
                direccionS.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(direccionS);
                HttpCookie fechaS = new HttpCookie("cantidadC");
                fechaS.Value = cantidad;
                fechaS.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(fechaS);
                HttpCookie idS = new HttpCookie("impuestoC");
                idS.Value = impuesto;
                idS.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(idS);
                HttpCookie direccionSo = new HttpCookie("preciocC");
                direccionSo.Value = precioc;
                direccionSo.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(direccionSo);
                HttpCookie fechaSo = new HttpCookie("loteC");
                fechaSo.Value = lote;
                fechaSo.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(fechaSo);
                HttpCookie idSo = new HttpCookie("fechaC");
                idSo.Value = fecha;
                idSo.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(idSo);
                HttpCookie idSod = new HttpCookie("unidadC");
                idSod.Value = unidad;
                idSod.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(idSod);
                HttpCookie id23S = new HttpCookie("indexC");
                id23S.Value = "2";
                id23S.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(id23S);
                Response.Redirect("ProductoEdicion.aspx");
            }
            else
            {
                int i = GridView2.SelectedIndex;
                string producto = GridView2.Rows[i].Cells[0].Text;
                string precio = GridView2.Rows[i].Cells[1].Text;
                string row = GridView2.Rows[i].Cells[2].Text;
                string preciod = GridView2.Rows[i].Cells[3].Text;
                string categoria = GridView2.Rows[i].Cells[4].Text;
                string cantidad = GridView2.Rows[i].Cells[5].Text;
                string impuesto = GridView2.Rows[i].Cells[6].Text;
                string precioc = GridView2.Rows[i].Cells[7].Text;
                string lote = GridView2.Rows[i].Cells[8].Text;
                string fecha = GridView2.Rows[i].Cells[9].Text;
                string unidad = GridView2.Rows[i].Cells[10].Text;
                HttpCookie nombreS = new HttpCookie("productoC");
                nombreS.Value = producto;
                nombreS.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(nombreS);
                HttpCookie apellidoS = new HttpCookie("precioC");
                apellidoS.Value = precio;
                apellidoS.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(apellidoS);
                HttpCookie correoS = new HttpCookie("rowC");
                correoS.Value = row;
                correoS.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(correoS);
                HttpCookie telefonoS = new HttpCookie("preciodC");
                telefonoS.Value = preciod;
                telefonoS.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(telefonoS);
                HttpCookie direccionS = new HttpCookie("categoriaC");
                direccionS.Value = categoria;
                direccionS.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(direccionS);
                HttpCookie fechaS = new HttpCookie("cantidadC");
                fechaS.Value = cantidad;
                fechaS.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(fechaS);
                HttpCookie idS = new HttpCookie("impuestoC");
                idS.Value = impuesto;
                idS.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(idS);
                HttpCookie direccionSo = new HttpCookie("preciocC");
                direccionSo.Value = precioc;
                direccionSo.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(direccionSo);
                HttpCookie fechaSo = new HttpCookie("loteC");
                fechaSo.Value = lote;
                fechaSo.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(fechaSo);
                HttpCookie idSo = new HttpCookie("fechaC");
                idSo.Value = fecha;
                idSo.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(idSo);
                HttpCookie idSod = new HttpCookie("unidadC");
                idSod.Value = unidad;
                idSod.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(idSod);
                HttpCookie id23S = new HttpCookie("indexC");
                id23S.Value = "2";
                id23S.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(id23S);
                Response.Redirect("ProductoEdicion.aspx");
            }
            
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string buscar = Correo.Value;
            HttpCookie buscarS = new HttpCookie("paramseisC");
            buscarS.Value = buscar;
            buscarS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(buscarS);
            Response.Redirect("ProdEditar.aspx");
        }
    }
}