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
    public partial class ClienteEdicion : System.Web.UI.Page
    {       
        string FECHAD;
        string IDD;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["indexC"] != null)
            {
                if (Request.Cookies["indexC"].Value == "1")
                {
                    Label6.Attributes.Add("style", "display:none");
                    CLI.Attributes.Add("style", "display:none");
                    if (Request.Cookies["nombreC"] != null)
                    {
                        Nombre.Value = Request.Cookies["nombreC"].Value;
                        //Apellido.Value = Request.Cookies["apellidoC"].Value;
                        Correo.Value = Request.Cookies["correoC"].Value;
                        Telefono.Value = Request.Cookies["telefonoC"].Value;
                        Dirección.Value = Request.Cookies["direccionC"].Value;
                        Text1.Value = Request.Cookies["rifC"].Value;
                        FECHAD = Request.Cookies["fechaC"].Value;
                        Text2.Value = Request.Cookies["sicmC"].Value;
                        IDD = Request.Cookies["idC"].Value;
                        Response.Cookies["nombreC"].Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies["apellidoC"].Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies["correoC"].Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies["telefonoC"].Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies["direccionC"].Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies["rifC"].Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies["sicm"].Expires = DateTime.Now.AddDays(-1);
                    }
                    else
                    {
                        FECHAD = Request.Cookies["fechaC"].Value;
                        IDD = Request.Cookies["idC"].Value;
                    }
                }
                else if (Request.Cookies["indexC"].Value == "2")
                {
                    Label1.Attributes.Add("style", "display:none");
                    PROV.Attributes.Add("style", "display:none");
                    if (Request.Cookies["nombreC"] != null)
                    {
                        Nombre.Value = Request.Cookies["nombreC"].Value;
                        //Apellido.Value = Request.Cookies["apellidoC"].Value;
                        Correo.Value = Request.Cookies["correoC"].Value;
                        Telefono.Value = Request.Cookies["telefonoC"].Value;
                        Dirección.Value = Request.Cookies["direccionC"].Value;
                        Text1.Value = Request.Cookies["rifC"].Value;
                        FECHAD = Request.Cookies["fechaC"].Value;
                        Text2.Value = Request.Cookies["sicmC"].Value;
                        IDD = Request.Cookies["idC"].Value;
                        Response.Cookies["nombreC"].Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies["apellidoC"].Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies["correoC"].Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies["telefonoC"].Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies["direccionC"].Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies["rifC"].Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies["sicm"].Expires = DateTime.Now.AddDays(-1);
                    }
                    else
                    {
                        FECHAD = Request.Cookies["fechaC"].Value;
                        IDD = Request.Cookies["idC"].Value;
                    }
                }

            }
            else
            {
                Label1.Attributes.Add("style", "display:none");
                PROV.Attributes.Add("style", "display:none");
                if (Request.Cookies["nombreC"] != null)
                {
                    Nombre.Value = Request.Cookies["nombreC"].Value;
                    //Apellido.Value = Request.Cookies["apellidoC"].Value;
                    Correo.Value = Request.Cookies["correoC"].Value;
                    Telefono.Value = Request.Cookies["telefonoC"].Value;
                    Dirección.Value = Request.Cookies["direccionC"].Value;
                    Text1.Value = Request.Cookies["rifC"].Value;
                    FECHAD = Request.Cookies["fechaC"].Value;
                    Text2.Value = Request.Cookies["sicmC"].Value;
                    IDD = Request.Cookies["idC"].Value;
                    Response.Cookies["nombreC"].Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies["apellidoC"].Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies["correoC"].Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies["telefonoC"].Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies["direccionC"].Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies["rifC"].Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies["sicm"].Expires = DateTime.Now.AddDays(-1);
                }
                else
                {
                    FECHAD = Request.Cookies["fechaC"].Value;
                    IDD = Request.Cookies["idC"].Value;
                }
            }


        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["indexC"] != null)
            {
                Response.Cookies["indexC"].Expires = DateTime.Now.AddDays(-1);
            }
            else { }
            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {
                string saveStaff = "UPDATE Clientes SET Nombre = @Nombre, Correo = @Correo, Telefono = @Telefono, Direccion = @Direccion, Rif = @Rif, sicm = @sicm WHERE iDCliente = @iDCliente";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre.Value;
                    //querySaveStaff.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = Apellido.Value;
                    querySaveStaff.Parameters.Add("@Correo", SqlDbType.VarChar).Value = Correo.Value;
                    querySaveStaff.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = Telefono.Value;
                    querySaveStaff.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Dirección.Value;
                    querySaveStaff.Parameters.Add("@Rif", SqlDbType.VarChar).Value = Text1.Value;
                    querySaveStaff.Parameters.Add("@FechaRegistro", SqlDbType.DateTime).Value = DateTime.Parse(FECHAD);
                    querySaveStaff.Parameters.Add("@iDCliente", SqlDbType.UniqueIdentifier).Value = Guid.Parse(IDD);
                    querySaveStaff.Parameters.Add("@sicm", SqlDbType.VarChar).Value = Text2.Value;
                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
                        
                        Response.Redirect("Lista.aspx");
                        Response.Write("<script>alert('CLIENTE ACTUALIZADO')</script>");
                    }
                    catch (SqlException ex)
                    {
                        Response.Write("Error" + ex);
                    }
                }




            }
        }
    }
}