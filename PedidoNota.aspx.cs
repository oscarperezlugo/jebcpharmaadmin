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
    public partial class PedidoNota : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string tasa;
            int valor;
            string connectionString = Conection.ConexLine;
            string query = "select max(NroOp) from cabecera where Tipo = 'NOTA DE ENTREGA'";


            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {

                con.Open();


                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    if (dr.Read())
                    {
                        if (dr.IsDBNull(0))
                        {

                            tasa = "0";
                            valor = Int32.Parse(tasa);

                        }
                        else
                        {
                            tasa = dr.GetFieldValue<int>(0).ToString();
                            valor = Int32.Parse(tasa) + 1;


                        }


                    }
                    else
                    {
                        tasa = "0";
                        valor = Int32.Parse(tasa);

                    }



                    dr.Close();
                }

                con.Close();
            }
           
            HttpCookie index2S3r = new HttpCookie("numeropC");
            index2S3r.Value = valor.ToString();
            index2S3r.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(index2S3r);
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            //int nota;
            //if (DropDownList5.SelectedValue == "")
            //{
            //    nota = 0;
            //}
            //else
            //{
            //    nota = Int32.Parse(DropDownList5.SelectedValue);
            //}
            System.Guid GUID = System.Guid.NewGuid();
            HttpCookie indexS = new HttpCookie("clienteC");
            indexS.Value = DropDownList1.SelectedValue;
            indexS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(indexS);
            HttpCookie index2S = new HttpCookie("idventaC");
            index2S.Value = GUID.ToString();
            index2S.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(index2S);
            //HttpCookie index2S1 = new HttpCookie("obser1C");
            //index2S1.Value = Nombre.Value;
            //index2S1.Expires = DateTime.Now.AddDays(30);
            //Response.Cookies.Add(index2S1);
            //HttpCookie index2S2 = new HttpCookie("obser2C");
            //index2S2.Value = Text1.Value;
            //index2S2.Expires = DateTime.Now.AddDays(30);
            //Response.Cookies.Add(index2S2);
            //HttpCookie index2S3 = new HttpCookie("obser3C");
            //index2S3.Value = Text3.Value;
            //index2S3.Expires = DateTime.Now.AddDays(30);
            //Response.Cookies.Add(index2S3);
            //HttpCookie index2S3r = new HttpCookie("numeropC");
            //index2S3r.Value = Text1.Value;
            //index2S3r.Expires = DateTime.Now.AddDays(30);
            //Response.Cookies.Add(index2S3r);
            using (SqlConnection openCon = new SqlConnection(Conection.ConexLine))
            {
                string saveStaff = "INSERT into Cabecera (FechaVenta, iDVenta, Tipo, Status, TipoVenta, Vendedor, Ref) VALUES (@FechaVenta, @iDVenta, @Tipo, 'PAGO POR VERIFICAR', @TipoVenta, @Vendedor, @Ref)";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = DateTime.Now;
                    querySaveStaff.Parameters.Add("@iDVenta", SqlDbType.UniqueIdentifier).Value = GUID;
                    querySaveStaff.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = DropDownList3.SelectedValue;
                    querySaveStaff.Parameters.Add("@TipoVenta", SqlDbType.VarChar).Value = DropDownList2.SelectedValue;
                    querySaveStaff.Parameters.Add("@Vendedor", SqlDbType.VarChar).Value = DropDownList4.SelectedValue;
                    querySaveStaff.Parameters.Add("@Ref", SqlDbType.Int).Value = 0;

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
                Response.Redirect("PedidoTres.aspx");
            }
        }
        protected void fijarproceso(object sender, EventArgs e)
        {
            string tasa;
            int valor;
            if (DropDownList3.SelectedValue == "PEDIDO")
            {
                string connectionString = Conection.ConexLine;
                string query = "select count(status) from Cabecera where tipo = 'PEDIDO' and row > 197";


                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    con.Open();


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        if (dr.Read())
                        {
                            if (dr.IsDBNull(0))
                            {

                                tasa = "0";
                                valor = Int32.Parse(tasa);

                            }
                            else
                            {
                                tasa = dr.GetFieldValue<int>(0).ToString();
                                valor = Int32.Parse(tasa);


                            }


                        }
                        else
                        {
                            tasa = "0";
                            valor = Int32.Parse(tasa) + 2539;

                        }



                        dr.Close();
                    }

                    con.Close();
                }
                
            }
            else 
            {
                string connectionString = Conection.ConexLine;
                string query = "select count(status) from Cabecera where tipo = 'NOTA DE ENTREGA' and row > 197";


                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    con.Open();


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        if (dr.Read())
                        {
                            if (dr.IsDBNull(0))
                            {

                                tasa = "0";
                                valor = Int32.Parse(tasa);

                            }
                            else
                            {
                                tasa = dr.GetFieldValue<int>(0).ToString();
                                valor = Int32.Parse(tasa);


                            }


                        }
                        else
                        {
                            tasa = "0";
                            valor = Int32.Parse(tasa) + 1600;

                        }



                        dr.Close();
                    }

                    con.Close();
                }
            }

            
            HttpCookie index2S3r = new HttpCookie("numeropC");
            index2S3r.Value = valor.ToString();
            index2S3r.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(index2S3r);
        }
    }
}