using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PanelAdmin
{
    public partial class Categoria : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Byte[] Archivo = null;
            
            if (FileUpload1.HasFile == true)
            {
                using (BinaryReader reader = new
                BinaryReader(FileUpload1.PostedFile.InputStream))
                {
                    Archivo = reader.ReadBytes(FileUpload1.PostedFile.ContentLength);
                    
                }                
            }
            if (Nombre.Value !=null)
            {

                using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                {
                    string saveStaff = "INSERT into Categorias (Categoria, Foto) VALUES (@Categoria, @Foto)";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = Nombre.Value.ToString();                        
                        querySaveStaff.Parameters.Add("@Foto", SqlDbType.Image).Value = Archivo;                        
                        try
                        {
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                            openCon.Close();
                            Response.Write("<script>alert('CATEGORIA CREADA')</script>");
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
                Response.Write("<script>alert('DATOS INCOMPLETOS')</script>");
            }

        }
    }
}