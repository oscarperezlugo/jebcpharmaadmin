﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PanelAdmin
{
    public partial class CotizacionDos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList2.Attributes.Add("style", "display:none");
            prefifin.Text = "0,00";
            Label5.Text = "0,00";
            DropDownList2.Enabled = false;
        }
        protected void Prod(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear();
            SqlConnection con = new SqlConnection("workstation id=jebcpharma.mssql.somee.com;packet size=4096;user id=paladar_SQLLogin_1;pwd=bgofrm6416;data source=jebcpharma.mssql.somee.com;persist security info=False;initial catalog=jebcpharma");
            SqlCommand cmd = new SqlCommand("select Precio from Producto where Producto = '" + DropDownList1.SelectedValue + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DropDownList2.DataSource = dt;
            DropDownList2.DataBind();
            Label5.Text = DropDownList2.SelectedValue;
            
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            double m;
            int z;
            if (Request.Cookies["totalC"] == null)
            {
                m = double.Parse(DropDownList2.SelectedValue) * Int32.Parse(Correo.Text);
            }
            else
            {
                double n = Double.Parse(Request.Cookies["totalC"].Value);
                double x = Double.Parse(DropDownList2.SelectedValue) * Int32.Parse(Correo.Text);
                m = n + x;
            }
            HttpCookie totalS = new HttpCookie("totalC");
            totalS.Value = m.ToString();
            totalS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(totalS);
            //if (Request.Cookies["lineasC"] == null)
            //{
            //    z = 1;
            //}
            //else
            //{
            //    int n = Int32.Parse(Request.Cookies["lineasC"].Value);
            //    int x = 1;
            //    z = n + x;
            //}
            //HttpCookie total2S = new HttpCookie("lineasC");
            //total2S.Value = z.ToString();
            //total2S.Expires = DateTime.Now.AddDays(30);
            //Response.Cookies.Add(total2S);
            string Ejec = Request.Cookies["idventaC"].Value;
            using (SqlConnection openCon = new SqlConnection("workstation id=jebcpharma.mssql.somee.com;packet size=4096;user id=paladar_SQLLogin_1;pwd=bgofrm6416;data source=jebcpharma.mssql.somee.com;persist security info=False;initial catalog=jebcpharma"))
            {
                string saveStaff = "INSERT into Lineas (Producto, iDVenta, Cantidad, Precio) VALUES (@Producto, @iDVenta, @Cantidad, @Precio)";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Producto", SqlDbType.VarChar).Value = DropDownList1.SelectedValue;
                    querySaveStaff.Parameters.Add("@iDVenta", SqlDbType.UniqueIdentifier).Value = Guid.Parse(Ejec);
                    querySaveStaff.Parameters.Add("@Cantidad", SqlDbType.Int).Value = Int32.Parse(Correo.Text);
                    querySaveStaff.Parameters.Add("@Precio", SqlDbType.Money).Value = Decimal.Parse(DropDownList2.SelectedValue) * Int32.Parse(Correo.Text);
                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
                        Response.Write("<script>alert('PRODUCTO AGREGADO')</script>");
                    }
                    catch (SqlException ex)
                    {
                        Response.Write("Error" + ex);
                    }
                }               
            }
            using (SqlConnection openCon = new SqlConnection("workstation id=jebcpharma.mssql.somee.com;packet size=4096;user id=paladar_SQLLogin_1;pwd=bgofrm6416;data source=jebcpharma.mssql.somee.com;persist security info=False;initial catalog=jebcpharma"))
            {
                string saveStaff = "Update Cabecera set Monto = CASE when Monto IS NULL then @Monto  else  Monto + @Monto END where iDVenta = @iDVenta";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;


                    querySaveStaff.Parameters.Add("@Monto", SqlDbType.Money).Value = Decimal.Parse(DropDownList2.SelectedValue) * Int32.Parse(Correo.Text);
                    querySaveStaff.Parameters.Add("@iDVenta", SqlDbType.UniqueIdentifier).Value = Guid.Parse(Ejec);
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
        }
        protected void test(object sender, EventArgs e)
        {
            double V;
            double a = Double.Parse(Correo.Text);
            double b = Double.Parse(DropDownList2.SelectedValue);
            V = a * b;
            prefifin.Text = V.ToString();
            Label5.Text = DropDownList2.SelectedValue;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            int i = GridView1.SelectedIndex;
            string Ejec = Request.Cookies["idventaC"].Value;
            string Ejec2 = Request.Cookies["totalC"].Value;
            //string Ejec3 = Request.Cookies["lineasC"].Value;
            HttpCookie total2S = new HttpCookie("idclienteC");
            total2S.Value = GridView1.Rows[0].Cells[0].Text;
            total2S.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(total2S);
            using (SqlConnection openCon = new SqlConnection("workstation id=jebcpharma.mssql.somee.com;packet size=4096;user id=paladar_SQLLogin_1;pwd=bgofrm6416;data source=jebcpharma.mssql.somee.com;persist security info=False;initial catalog=jebcpharma"))
            {
                string saveStaff = "UPDATE Cabecera SET iDCliente=@iDCliente, Direccion=@Direccion, Rif=@Rif WHERE iDVenta=@iDVenta";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    
                    querySaveStaff.Parameters.Add("@iDVenta", SqlDbType.UniqueIdentifier).Value = Guid.Parse(Ejec);                    
                    //querySaveStaff.Parameters.Add("@Lineas", SqlDbType.Int).Value = Ejec3;
                    querySaveStaff.Parameters.Add("@iDCliente", SqlDbType.UniqueIdentifier).Value = Guid.Parse(GridView1.Rows[0].Cells[0].Text);
                    querySaveStaff.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = GridView1.Rows[0].Cells[3].Text;
                    querySaveStaff.Parameters.Add("@Rif", SqlDbType.VarChar).Value = GridView1.Rows[0].Cells[2].Text;
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
                Response.Redirect("CotizacionTotal.aspx");
            }
        }
    }
}