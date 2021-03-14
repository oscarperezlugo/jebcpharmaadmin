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
    public partial class Cobranza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            
                using (SqlConnection openCon = new SqlConnection("workstation id=jebcpharma.mssql.somee.com;packet size=4096;user id=paladar_SQLLogin_1;pwd=bgofrm6416;data source=jebcpharma.mssql.somee.com;persist security info=False;initial catalog=jebcpharma"))
                {
                    string saveStaff = "INSERT into Pagos (Metodo, Correo, Fecha, FactPagada, Cinfirmacion, Moneda, Banco, MontoFin) VALUES (@Metodo, @Correo, @Fecha, @FactPagada, @Confirmacion, @Moneda, @Banco, @MontoFin)";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Metodo", SqlDbType.VarChar).Value = DropDownList1.SelectedValue.ToString();                        
                        querySaveStaff.Parameters.Add("@Correo", SqlDbType.VarChar).Value = "";
                        querySaveStaff.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = Text2.Value.ToString();
                        querySaveStaff.Parameters.Add("@FactPagada", SqlDbType.VarChar).Value = DropDownList3.SelectedValue.ToString();
                        querySaveStaff.Parameters.Add("@Confirmacion", SqlDbType.VarChar).Value = DropDownList4.SelectedValue.ToString();
                        querySaveStaff.Parameters.Add("@Moneda", SqlDbType.VarChar).Value = DropDownList2.SelectedValue.ToString();
                        querySaveStaff.Parameters.Add("@Banco", SqlDbType.VarChar).Value = Telefono.Value.ToString();
                        querySaveStaff.Parameters.Add("@MontoFin", SqlDbType.VarChar).Value = Contrasena.Value.ToString();
                    try
                        {
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                            openCon.Close();
                            Response.Write("<script>alert('PAGO REGISTRADO')</script>");
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