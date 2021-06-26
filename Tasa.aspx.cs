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
    public partial class Tasa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = Conection.ConexLine;
            string query = "SELECT TOP 1 Tasa, Fecha, Row FROM Tasa ORDER BY Row DESC";


            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
               
                con.Open();


                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        double tasa = dr.GetFieldValue<double>(0);                        

                        TagTasa.InnerText = tasa.ToString();

                    }
                    else
                    {                       

                    }

                    dr.Close();
                }

                con.Close();
            }

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Decimal multi = Decimal.Parse(TasaDia.Value);
            using (SqlConnection openCon = new SqlConnection("workstation id=jebcpharma.mssql.somee.com;packet size=4096;user id=paladar_SQLLogin_1;pwd=bgofrm6416;data source=jebcpharma.mssql.somee.com;persist security info=False;initial catalog=jebcpharma"))
            {
                string saveStaff = "INSERT into Tasa (Tasa, Fecha) VALUES (@Tasa, @Fecha)";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Tasa", SqlDbType.Float).Value = TasaDia.Value;
                    querySaveStaff.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = DateTime.Now;                    
                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
                        TasaDia.Value = "";
                    }
                    catch (SqlException ex)
                    {
                        Response.Write("Error" + ex);
                    }
                }
                string saveStaffdos = "UPDATE Producto set Precio = PrecioD * @Tasa";

                using (SqlCommand querySaveStaffdos = new SqlCommand(saveStaffdos))
                {
                    querySaveStaffdos.Connection = openCon;
                    querySaveStaffdos.Parameters.Add("@Tasa", SqlDbType.Money).Value = multi;                    
                    try
                    {
                        openCon.Open();
                        querySaveStaffdos.ExecuteNonQuery();
                        openCon.Close();
                        Response.Write("<script>alert('TASA ACTUALIZADA')</script>");
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
    
