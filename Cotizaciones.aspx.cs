using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PanelAdmin
{
    public partial class Cotizaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Operacion"] != null)
            {
                if (GridView2.Rows.Count == 0)
                {

                    GridView2.Attributes.Add("style", "display:none");
                    Response.Cookies["Operacion"].Expires = DateTime.Now.AddDays(-1);
                }
                else
                {
                    GridView1.Attributes.Add("style", "display:none");
                    Response.Cookies["Operacion"].Expires = DateTime.Now.AddDays(-1);
                }
            }
            else
            {
                GridView2.Attributes.Add("style", "display:none");
                Response.Cookies["Operacion"].Expires = DateTime.Now.AddDays(-1);
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GridView2.Rows.Count == 0)
            {

                int i = GridView1.SelectedIndex;
                string id = GridView1.Rows[i].Cells[3].Text;
                string idcliente = GridView1.Rows[i].Cells[0].Text;
                HttpCookie idS = new HttpCookie("idventaC");
                idS.Value = id;
                idS.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(idS);
                HttpCookie idclienteS = new HttpCookie("idclienteC");
                idclienteS.Value = idcliente;
                idclienteS.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(idclienteS);
                Response.Redirect("CotizacionTotal.aspx");
            }
            else
            {
                int i = GridView2.SelectedIndex;
                string id = GridView2.Rows[i].Cells[3].Text;
                string idcliente = GridView2.Rows[i].Cells[0].Text;
                HttpCookie idS = new HttpCookie("idventaC");
                idS.Value = id;
                idS.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(idS);
                HttpCookie idclienteS = new HttpCookie("idclienteC");
                idclienteS.Value = idcliente;
                idclienteS.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(idclienteS);
                Response.Redirect("CotizacionTotal.aspx");
            }
           
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {


            HttpCookie buscarS = new HttpCookie("Operacion");
            buscarS.Value = Correo.Value;
            buscarS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(buscarS);
            

            Response.Redirect("Cotizaciones.aspx");

        }
    }
}