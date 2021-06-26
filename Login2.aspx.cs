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
    public partial class Login2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string connectionString = Conection.ConexLine;
            string query = "SELECT Nombre, Row, Tipo, Apellido FROM Usuario WHERE Correo=@Correo AND Contraseno=@Pass AND Tipo='VENDEDOR'";


            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {

                cmd.Parameters.Add("@Correo", SqlDbType.VarChar, 50).Value = Correo.Value.ToString();
                cmd.Parameters.Add("@Pass", SqlDbType.VarChar, 50).Value = Contrasena.Value.ToString();


                con.Open();


                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        string nombre = dr.GetFieldValue<string>(0);
                        int Row = dr.GetFieldValue<int>(1);
                        string Perfil = dr.GetFieldValue<string>(2);
                        string Apellido = dr.GetFieldValue<string>(3);
                        
                        HttpCookie nombreS = new HttpCookie("nombreC");
                        nombreS.Value = nombre;
                        nombreS.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(nombreS);

                        HttpCookie nombre2S = new HttpCookie("appellC");
                        nombre2S.Value = Apellido;
                        nombre2S.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(nombre2S);

                        HttpCookie idclienteS = new HttpCookie("rowC");
                        idclienteS.Value = Row.ToString();
                        idclienteS.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(idclienteS);

                        HttpCookie perfilS = new HttpCookie("PerfilC");
                        perfilS.Value = Perfil;
                        perfilS.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(perfilS);

                        


                        Response.Write("<script>alert('BIENVENIDO')</script>");


                        Response.Redirect("Default.aspx");



                    }
                    else
                    {
                        Response.Write("<script>alert('Usuario y Contraseña incorrectos')</script>");

                    }

                    dr.Close();
                }

                con.Close();
            }
        }
    }
}