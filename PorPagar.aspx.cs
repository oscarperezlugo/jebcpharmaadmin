using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PanelAdmin
{
    public partial class PorPagar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
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
            Response.Redirect("PedidoDetalleCuatro.aspx");
        }
    }
}