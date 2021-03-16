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
            Label7.Text = DateTime.Now.ToString();
            Label9.Text = GridView2.Rows[0].Cells[1].Text;
            Label17.Text = GridView2.Rows[0].Cells[1].Text;
            Label22.Text = GridView2.Rows[0].Cells[3].Text;
            string a = GridView4.Rows[0].Cells[2].Text;
            Label24.Text = string.Format("{0:D2}", a);
            Label25.Text = GridView4.Rows[0].Cells[2].Text;
            //Label10.Text = "CENTRO " + Nombre.Value + "";
            //Label11.Text = "NUMERO DE PEDIDO " + Text1.Value + "";
            //Label12.Text = "NOTA DE ENTREGA " + Text2.Value + "";
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Label10.Text = "CENTRO " + Nombre.Value + "";
            Label11.Text = "NUMERO DE PEDIDO " + Text1.Value + "";
            Label12.Text = "NOTA DE ENTREGA " + Text2.Value + "";
            PrintBut.OnClientClick = "javascript:window.print();";
            
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