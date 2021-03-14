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
    public partial class ProductoEdicion : System.Web.UI.Page
    {
        string ROW;
        string FOTO;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["indexC"] != null)
            {
                Nombre.Value = Request.Cookies["productoC"].Value;                
                ROW = Request.Cookies["rowC"].Value;
                Precio.Value = Request.Cookies["preciodC"].Value;
                DropDownList1.SelectedValue = Request.Cookies["categoriaC"].Value;
                Cantidad.Value = Request.Cookies["cantidadC"].Value;
                DropDownList2.SelectedValue = Request.Cookies["impuestoC"].Value;
                Number1.Value = Request.Cookies["preciocC"].Value;
                Text1.Value = Request.Cookies["loteC"].Value;
                Text2.Value = Request.Cookies["fechaC"].Value;
                Datetimelocal1.Value = Request.Cookies["unidadC"].Value;
                
                
                Response.Cookies["productoC"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["precioC"].Expires = DateTime.Now.AddDays(-1);                
                Response.Cookies["preciodC"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["categoriaC"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["cantidadC"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["impuestoC"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["preciocC"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["loteC"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["fechaC"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["unidadC"].Expires = DateTime.Now.AddDays(-1);                
                Response.Cookies["indexC"].Expires = DateTime.Now.AddDays(-1);
            }
            else
            {

            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            

                using (SqlConnection openCon = new SqlConnection("workstation id=jebcpharma.mssql.somee.com;packet size=4096;user id=paladar_SQLLogin_1;pwd=bgofrm6416;data source=jebcpharma.mssql.somee.com;persist security info=False;initial catalog=jebcpharma"))
                {
                    string saveStaff = "UPDATE Producto SET Producto=@Producto, PrecioD=@PrecioD, Categoria=@Categoria, Cantidad=@Cantidad, Impuesto=@Impuesto, PrecioCompra=@PrecioCompra, cpe=@cpe, Lote=@Lote, FechaVenc=@FechaVenc, Unidad=@Unidad WHERE Row=@Row";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = Nombre.Value.ToString();                                                                      
                        querySaveStaff.Parameters.Add("@PrecioD", SqlDbType.Money).Value = Precio.Value;
                        querySaveStaff.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                        querySaveStaff.Parameters.Add("@Cantidad", SqlDbType.Int).Value = Int16.Parse(Cantidad.Value);
                        querySaveStaff.Parameters.Add("@Impuesto", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;                                               
                        querySaveStaff.Parameters.Add("@PrecioCompra", SqlDbType.Money).Value = Number1.Value;
                        querySaveStaff.Parameters.Add("@cpe", SqlDbType.VarChar).Value = Text3.Value;
                        querySaveStaff.Parameters.Add("@Lote", SqlDbType.VarChar).Value = Text1.Value.ToString();
                        querySaveStaff.Parameters.Add("@FechaVenc", SqlDbType.DateTime).Value = Text2.Value;
                        querySaveStaff.Parameters.Add("@Unidad", SqlDbType.VarChar).Value = Datetimelocal1.Value.ToString();
                        querySaveStaff.Parameters.Add("@Row", SqlDbType.Int).Value = Int32.Parse(Request.Cookies["rowC"].Value);
                        try
                        {
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                            openCon.Close();
                            Response.Write("<script>alert('PRODUCTO ACTUALIZADO')</script>");
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