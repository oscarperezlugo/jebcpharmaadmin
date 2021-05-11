using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PanelAdmin
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["nombreC"] != null)
            {
                Label1.Text = "" + Request.Cookies["nombreC"].Value + " " + Request.Cookies["appellC"].Value + "";
                if(Request.Cookies["perfilC"] != null)
                {
                    if (Request.Cookies["perfilC"].Value == "ADMIN")
                    {

                    }
                    else if (Request.Cookies["perfilC"].Value == "VENDEDOR")
                    {
                        bloque2.Attributes.Add("style", "display:none");
                        bloque3.Attributes.Add("style", "display:none");
                        bloque4.Attributes.Add("style", "display:none");
                    }
                    else if (Request.Cookies["perfilC"].Value == "CONTADOR")
                    {
                        bloque2.Attributes.Add("style", "display:none");
                        bloque3.Attributes.Add("style", "display:none");
                        bloque1.Attributes.Add("style", "display:none");
                        bloque5.Attributes.Add("style", "display:none");
                    }
                    else if (Request.Cookies["perfilC"].Value == "SERVICIO")
                    {
                        bloque4.Attributes.Add("style", "display:none");
                        bloque3.Attributes.Add("style", "display:none");
                        bloque1.Attributes.Add("style", "display:none");
                        bloque5.Attributes.Add("style", "display:none");
                    }
                    else
                    {

                        Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('NO AUTORIZADO');window.location='Login.aspx'</script>");
                    }
                }
                else
                {
                    Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('NO AUTORIZADO');window.location='Login.aspx'</script>");
                }

            }
            else
            {
                Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('NO AUTORIZADO');window.location='Login.aspx'</script>");
            }
            
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            if (HttpContext.Current != null)
            {
                int cookieCount = HttpContext.Current.Request.Cookies.Count;
                for (var i = 0; i < cookieCount; i++)
                {
                    var cookie = HttpContext.Current.Request.Cookies[i];
                    if (cookie != null)
                    {
                        var expiredCookie = new HttpCookie(cookie.Name)
                        {
                            Expires = DateTime.Now.AddDays(-1),
                            Domain = cookie.Domain
                        };
                        HttpContext.Current.Response.Cookies.Add(expiredCookie); // overwrite it
                    }
                }

                // clear cookies server side
                HttpContext.Current.Request.Cookies.Clear();
            }
            Response.Redirect("Login.aspx");
        }
    }
}