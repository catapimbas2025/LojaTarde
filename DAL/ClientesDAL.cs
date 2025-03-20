using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Modelos;

namespace DAL 
{                                                                                                                                                                                                                                                                                                                                                                          
    public class ClientesDAL
    {
       
        public void Incluir(ClientesInformation cliente)
        {
            //CONEXÃO
            SqlConnection cn = new SqlConnection();
            try
            {
              
                cn.ConnectionString = "Data Source=DESKTOP-V4V6Q6M;Initial Catalog=LOJADB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Insere_Clientes";

                //PARAMETROS DA STORED PROCEDURE
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pnome = new SqlParameter("@nome", SqlDbType.VarChar, 100);
                pnome.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pnome);

                SqlParameter pemail = new SqlParameter("@email", SqlDbType.VarChar, 100);
                pemail.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pemail);

                SqlParameter ptelefone = new SqlParameter("@telefone", SqlDbType.VarChar, 80);
                ptelefone.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(ptelefone);

                cn.Open();
                cmd.ExecuteNonQuery();

                cliente.Codigo = (Int32)cmd.Parameters["@codigo"].Value;
            }   

            catch (Exception ex)
            {

                throw new Exception("Servidor SQL erro: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }




        }
        



        public void Alterar(ClientesInformation cliente)
        {
            //CONEXÃO 
            SqlConnection cn = new SqlConnection();
            try
            {
             cn.ConnectionString = "Data Source=DESKTOP-V4V6Q6M;Initial Catalog=LOJADB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "altera_clientes";

                //PARAMETROS DA STORED PROCEDURE
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pnome = new SqlParameter("@nome", SqlDbType.VarChar, 100);
                pnome.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pnome);

                SqlParameter pemail = new SqlParameter("@email", SqlDbType.VarChar, 100);
                pemail.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pemail);

                SqlParameter ptelefone = new SqlParameter("@telefone", SqlDbType.VarChar, 80);
                ptelefone.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(ptelefone);

                cn.Open();

                cmd.ExecuteNonQuery();
                cliente.Codigo = (Int32)cmd.Parameters["@codigo"].Value;

            }
            catch (Exception ex)
            {

                throw new Exception("Servidor SQL erro: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }



        public void Excluir(int codigo)
        {
            //CONEXÃO
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = "Data Source=DESKTOP-V4V6Q6M;Initial Catalog=LOJADB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "exclui_clientes";

                //PARAMETROS DO CÓDIGO
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Value = codigo;
                cmd.Parameters.Add(pcodigo);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if(resultado !=1)
                {
                    throw new Exception("Não foi possível excluir o cliente" + codigo);
                }

            }
            catch (Exception ex)
            {

                throw new Exception("Servidor SQL erro: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
