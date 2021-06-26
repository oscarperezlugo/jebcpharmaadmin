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
    public partial class Proveedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {
                string saveStaff = "INSERT into Clientes (Nombre, Correo, Telefono, Direccion, FechaRegistro, Contrasena, iDCliente, Rif, Tipo, PersonaFinal, Telefono2) VALUES (@Nombre, @Correo, @Telefono, @Direccion, @FechaRegistro, @Contrasena, @iDCliente, @Rif, 'PROVEEDOR', @PersonaFinal, @Telefono2)";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre.Value.ToString();
                    querySaveStaff.Parameters.Add("@Correo", SqlDbType.VarChar).Value = Correo.Value.ToString();
                    querySaveStaff.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = Telefono.Value.ToString();
                    querySaveStaff.Parameters.Add("@Telefono2", SqlDbType.VarChar).Value = Repetir.Value.ToString();
                    querySaveStaff.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Text1.Value.ToString();
                    querySaveStaff.Parameters.Add("@FechaRegistro", SqlDbType.DateTime).Value = DateTime.Now;
                    querySaveStaff.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = Contraseña.Value.ToString();
                    querySaveStaff.Parameters.Add("@Rif", SqlDbType.VarChar).Value = Text2.Value.ToString();
                    querySaveStaff.Parameters.Add("@PersonaFinal", SqlDbType.VarChar).Value = Text3.Value.ToString();
                    querySaveStaff.Parameters.Add("@iDCliente", SqlDbType.UniqueIdentifier).Value = System.Guid.NewGuid();
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
    }
}