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
    public partial class PedidosEliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Operacion"] != null)
            {
                if (GridView2.Rows.Count == 0)
                {
                    
                    GridView2.Attributes.Add("style", "display:none");
                }
                else
                {
                    GridView1.Attributes.Add("style", "display:none");
                }
            }
            else
            {
                GridView2.Attributes.Add("style", "display:none");
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GridView2.Rows.Count == 0)
            {

                int i = GridView1.SelectedIndex;
                string id = GridView1.Rows[i].Cells[6].Text;
                string iddos = GridView1.Rows[i].Cells[5].Text;


                using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                {
                    string saveStaff = "Delete from Cabecera where Row=@Row";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;

                        querySaveStaff.Parameters.Add("@Row", SqlDbType.Int).Value = Int32.Parse(id);

                        try
                        {
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                            openCon.Close();

                        }
                        catch (SqlException ex)
                        {
                            Response.Write("Error" + ex);
                        }
                    }

                }
                using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                {
                    string saveStaff = "Delete from Lineas where iDVenta=@iDVenta";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;

                        querySaveStaff.Parameters.Add("@iDVenta", SqlDbType.UniqueIdentifier).Value = Guid.Parse(iddos);

                        try
                        {
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                            openCon.Close();
                            Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('FACTURA ELIMINAR');window.location='PedidosEliminar.aspx'</script>");
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
                int i = GridView2.SelectedIndex;
                string id = GridView2.Rows[i].Cells[6].Text;
                string iddos = GridView2.Rows[i].Cells[5].Text;


                using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                {
                    string saveStaff = "Delete from Cabecera where Row=@Row";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;

                        querySaveStaff.Parameters.Add("@Row", SqlDbType.Int).Value = Int32.Parse(id);

                        try
                        {
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                            openCon.Close();

                        }
                        catch (SqlException ex)
                        {
                            Response.Write("Error" + ex);
                        }
                    }

                }
                using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
                {
                    string saveStaff = "Delete from Lineas where iDVenta=@iDVenta";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;

                        querySaveStaff.Parameters.Add("@iDVenta", SqlDbType.UniqueIdentifier).Value = Guid.Parse(iddos);

                        try
                        {
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                            openCon.Close();
                            Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('FACTURA ELIMINAR');window.location='PedidosEliminar.aspx'</script>");
                        }
                        catch (SqlException ex)
                        {
                            Response.Write("Error" + ex);
                        }
                    }

                }
            }
            


        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {

           
            HttpCookie buscarS = new HttpCookie("Operacion");
            buscarS.Value = Correo.Value;
            buscarS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(buscarS);
            DateTime FECHA = DateTime.Now;
          
            Response.Redirect("PedidosEliminar.aspx");

        }
    }
}