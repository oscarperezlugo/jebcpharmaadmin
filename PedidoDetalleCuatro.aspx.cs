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
    public partial class PedidoDetalleCuatro : System.Web.UI.Page
    {
        string VENTA;
        protected void Page_Load(object sender, EventArgs e)
        {
            VENTA = Request.Cookies["idventaC"].Value;
            string connectionString = Conection.ConexLine;
            string query = "SELECT Row, Monto, MontoD FROM Cabecera WHERE iDVenta=@Correo";


            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {

                cmd.Parameters.Add("@Correo", SqlDbType.VarChar, 50).Value = VENTA;
               


                con.Open();


                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        string nombre = dr.GetFieldValue<Int32>(0).ToString();
                        string monto = dr.GetFieldValue<Decimal>(1).ToString("#,#");
                        string montod = dr.GetFieldValue<Decimal>(2).ToString("#,#");
                        Label6.Text = "ORDEN DE COMPRA # "+nombre+"";
                        GridView2.FooterRow.Cells[3].Text = monto;
                        GridView2.FooterRow.Cells[2].Text = "TOTAL:";
                        GridView2.FooterRow.Cells[1].Text = "TOTAL GENERAL $: " + montod + "";








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
            if (GridView1.Rows[0].Cells[1].Text == "PENDIENTE")
            {
                STATUS = "PAGADO";
            }
            else
            {
                STATUS = "PAGADO";
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
                        Response.Write("<script>alert('COMPRA ACTUALIZADO')</script>");
                       
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