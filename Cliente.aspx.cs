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
    public partial class Cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if (Contraseña.Value.ToString() == Repetir.Value.ToString())
            {

                using (SqlConnection openCon = new SqlConnection("workstation id=jebcpharma.mssql.somee.com;packet size=4096;user id=paladar_SQLLogin_1;pwd=bgofrm6416;data source=jebcpharma.mssql.somee.com;persist security info=False;initial catalog=jebcpharma"))
                {
                    string saveStaff = "INSERT into Clientes (Nombre, Correo, Telefono, Direccion, FechaRegistro, Contrasena, iDCliente, Rif, Tipo, sicm, Telefono2, TipoCliente, Persona, DireccionEntF, Vendedor) VALUES (@Nombre, @Correo, @Telefono, @Direccion, @FechaRegistro, @Contrasena, @iDCliente, @Rif, 'CLIENTE', @sicm, @Telefono2, @TipoCliente, @Persona, @DireccionEntF, @Vendedor)";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre.Value.ToString();
                        querySaveStaff.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = "";
                        querySaveStaff.Parameters.Add("@Correo", SqlDbType.VarChar).Value = Correo.Value.ToString();
                        querySaveStaff.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = Telefono.Value.ToString();
                        querySaveStaff.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Dirección.Value.ToString();
                        querySaveStaff.Parameters.Add("@DireccionEntF", SqlDbType.VarChar).Value = Text3.Value.ToString();
                        querySaveStaff.Parameters.Add("@FechaRegistro", SqlDbType.DateTime).Value = DateTime.Now;
                        querySaveStaff.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = Contraseña.Value.ToString();
                        querySaveStaff.Parameters.Add("@Rif", SqlDbType.VarChar).Value = Text1.Value.ToString();
                        querySaveStaff.Parameters.Add("@sicm", SqlDbType.VarChar).Value = Text2.Value.ToString();
                        querySaveStaff.Parameters.Add("@iDCliente", SqlDbType.UniqueIdentifier).Value = System.Guid.NewGuid();
                        querySaveStaff.Parameters.Add("@Telefono2", SqlDbType.VarChar).Value = Text41.Value.ToString();
                        querySaveStaff.Parameters.Add("@TipoCliente", SqlDbType.VarChar).Value = Text31.Value.ToString();
                        querySaveStaff.Parameters.Add("@Persona", SqlDbType.VarChar).Value = DropDownList2.SelectedValue.ToString();
                        querySaveStaff.Parameters.Add("@Vendedor", SqlDbType.VarChar).Value = DropDownList4.SelectedValue.ToString();
                        try
                        {
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                            openCon.Close();
                            Response.Write("<script>alert('USUARIO REGISTRADO')</script>");
                        }
                        catch (SqlException ex)
                        {
                            Response.Write("Error" + ex);
                        }
                    }
                }

            }
            else
            {
                Response.Write("<script>alert('LAS CONTRASEÑAS NO COINCIDEN')</script>");
            }
        }
    }
}