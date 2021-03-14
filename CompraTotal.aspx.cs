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
    public partial class CompraTotal : System.Web.UI.Page
    {
        //string VENTA;
        protected void Page_Load(object sender, EventArgs e)
        {
            //VENTA = Request.Cookies["idventaC"].Value;
            
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Session["ctrl"] = pnl1;
            
            ClientScript.RegisterStartupScript(this.GetType(), "onclick", "<script language=javascript>window.open('Print.aspx','PrintMe','height=600px,width=600px,scrollbars=1');</script>");
        }
    }
}