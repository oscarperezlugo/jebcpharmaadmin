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
    public partial class PedidoDetalleDos : System.Web.UI.Page
    {
        string VENTA;
        protected void Page_Load(object sender, EventArgs e)
        {
            VENTA = Request.Cookies["idventaP"].Value;
            string connectionString = Conection.ConexLine;
            string query = "SELECT NroOp FROM Cabecera WHERE iDVenta=@Correo";


            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {

                cmd.Parameters.Add("@Correo", SqlDbType.UniqueIdentifier).Value = Guid.Parse(VENTA);
               


                con.Open();


                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        string nombre = dr.GetFieldValue<Int32>(0).ToString();
                        Label6.Text = "OPERACION # "+nombre+"";




                        



                    }
                    else
                    {
                        

                    }

                    dr.Close();
                }

                con.Close();
            }
        }

    
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string STATUS;
            if (GridView1.Rows[0].Cells[4].Text == "VERIFICADO")
            {
                STATUS = "FINALIZADO";
            }
            else
            {
                STATUS = "VERIFICADO";
            }
            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {
                string saveStaff = "UPDATE Cabecera SET Status = @Status WHERE iDVenta = @iDVenta";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {

                    querySaveStaff.Connection = openCon;                    
                    querySaveStaff.Parameters.Add("@iDVenta", SqlDbType.UniqueIdentifier).Value = Guid.Parse(VENTA);
                    querySaveStaff.Parameters.Add("@Status", SqlDbType.VarChar).Value = STATUS;
                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
                        Response.Write("<script>alert('PEDIDO ACTUALIZADO')</script>");
                        Response.Redirect("Pedidos.aspx");
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