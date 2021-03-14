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
    public partial class ConsProdCli : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            System.Guid GUID = System.Guid.NewGuid();
            HttpCookie indexS = new HttpCookie("clienteR");
            indexS.Value = DropDownList1.SelectedValue;
            indexS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(indexS);
            HttpCookie index2S = new HttpCookie("productoR");
            index2S.Value = DropDownList2.SelectedValue;
            index2S.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(index2S);
            
            Response.Redirect("ProductoCliente.aspx");
            
        }
    }
}