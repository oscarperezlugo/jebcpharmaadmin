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
    public partial class PedidoTotal : System.Web.UI.Page
    {
        string VENTA;
        protected void Page_Load(object sender, EventArgs e)
        {
            VENTA = Request.Cookies["idventaC"].Value;
            Label1.Text = GridView2.Rows[0].Cells[0].Text;
            //Label20.Text = GridView2.Rows[0].Cells[0].Text;
            Label4.Text = GridView2.Rows[0].Cells[2].Text;
            Label7.Text = GridView1.Rows[0].Cells[2].Text;
            Label9.Text = GridView2.Rows[0].Cells[1].Text;
            Label17.Text = GridView2.Rows[0].Cells[1].Text;
            Label22.Text = GridView2.Rows[0].Cells[3].Text;
            string a = GridView4.Rows[0].Cells[2].Text;
            Label24.Text = string.Format("{0:#,#}", a);
            Label25.Text = GridView4.Rows[0].Cells[2].Text;
            GridView4.Attributes.Add("style","display: none;");
            if (Request.Cookies["obser1C"] == null)
            {

            }
            else
            {
                Label10.Text = "CENTRO " + Request.Cookies["obser1C"].Value + "";
            }
            if (Request.Cookies["obser2C"] == null)
            {

            }
            else
            {
                Label10.Text = "NUMERO DE PEDIDO " + Request.Cookies["obser2C"].Value + "";
            }
            if (Request.Cookies["obser3C"] == null)
            {

            }
            else
            {
                Label10.Text = "NOTA DE ENTREGA " + Request.Cookies["obser3C"].Value + "";
            }
            VENTA = Request.Cookies["idventaC"].Value;
            string connectionString = Conection.ConexLine;
            string query = "SELECT Row, Monto, MontoD FROM Cabecera WHERE iDVenta=@Correo";


            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {

                cmd.Parameters.Add("@Correo", SqlDbType.VarChar).Value = Guid.Parse(VENTA).ToString();



                con.Open();


                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        int nombre = dr.GetFieldValue<int>(0);
                        //Label1.Text = " " + nombre.ToString() + "";
                        string monto = dr.GetFieldValue<Decimal>(1).ToString("#,#");
                        string montod = dr.GetFieldValue<Decimal>(2).ToString("#,#");
                        GridView3.FooterRow.Cells[2].Text = monto;
                        GridView3.FooterRow.Cells[1].Text = "TOTAL:";
                        GridView3.FooterRow.Cells[0].Text = "TOTAL GENERAL $: " + montod + "";



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
            //Label10.Text = "CENTRO " + Nombre.Value + "";
            //Label11.Text = "NUMERO DE PEDIDO " + Text1.Value + "";
            //Label12.Text = "NOTA DE ENTREGA " + Text2.Value + "";
            //PrintBut.OnClientClick = "";
            
            //using (SqlConnection openCon = new SqlConnection("workstation id=jebcpharma.mssql.somee.com;packet size=4096;user id=paladar_SQLLogin_1;pwd=bgofrm6416;data source=jebcpharma.mssql.somee.com;persist security info=False;initial catalog=jebcpharma"))
            //{
            //    string saveStaff = "UPDATE Cabecera SET Status = 'VERIFICADO' WHERE iDVenta = @iDVenta";

            //    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
            //    {

            //        querySaveStaff.Connection = openCon;                    
            //        querySaveStaff.Parameters.Add("@iDVenta", SqlDbType.UniqueIdentifier).Value = Guid.Parse(VENTA);
            //        try
            //        {
            //            openCon.Open();
            //            querySaveStaff.ExecuteNonQuery();
            //            openCon.Close();
            //            Response.Write("<script>alert('PEDIDO ACTUALIZADO')</script>");
            //            Session["ctrl"] = pnl1;
            //            ClientScript.RegisterStartupScript(this.GetType(), "onclick", "<script language=javascript>window.open('Print.aspx','PrintMe','height=300px,width=300px,scrollbars=1');</script>");                        
            //        }
            //        catch (SqlException ex)
            //        {
            //            Response.Write("Error" + ex);
            //        }






        }
    }
}