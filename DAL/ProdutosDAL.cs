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
    public class ProdutosDAL
    {
        public void Incluir(ProdutosInformation produtos)
        {
            SqlConnection cn = new SqlConnection();
            try
            {

                cn.ConnectionString = Dados.StringDeConexao();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Insere_Produtos";

                //PARAMETROS DA STORED PROCEDURE
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pnome = new SqlParameter("@nome", SqlDbType.VarChar, 100);
                pnome.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pnome);

                SqlParameter ppreco = new SqlParameter("@preco", SqlDbType.Decimal, 10-2);
                ppreco.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(ppreco);

                SqlParameter pestoque = new SqlParameter("@estoque", SqlDbType.Int);
                pestoque.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pestoque);

                cn.Open();
                cmd.ExecuteNonQuery();

                produtos.Codigo = (Int32)cmd.Parameters["@codigo"].Value;
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

        //-----------------------------------------------------------------------------------//
        public void Alterar(ProdutosInformation produtos)
        {
            //CONEXÃO 
            SqlConnection cn = new SqlConnection();
            try
            {

                cn.ConnectionString = Dados.StringDeConexao();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Insere_Produtos";

                //PARAMETROS DA STORED PROCEDURE
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pnome = new SqlParameter("@nome", SqlDbType.VarChar, 100);
                pnome.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pnome);

                SqlParameter ppreco = new SqlParameter("@preco", SqlDbType.Decimal, 10-2);
                ppreco.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(ppreco);

                SqlParameter pestoque = new SqlParameter("@estoque", SqlDbType.Int);
                pestoque.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pestoque);

                cn.Open();
                cmd.ExecuteNonQuery();

                produtos.Codigo = (Int32)cmd.Parameters["@codigo"].Value;
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
        //-----------------------------------------------------------------------------------//
        public void Excluir(int codigo)
        {
            //CONEXÃO
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Exclui_Produtos";

                //PARAMETROS DO CÓDIGO
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Value = codigo;
                cmd.Parameters.Add(pcodigo);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o produto" + codigo);
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
        //-----------------------------------------------------------------------------------//
        public DataTable Listagem(string filtro)
        {
            SqlConnection cn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao();
                //adapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "Seleciona_Produtos";
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                //PARAMETROS DO FILTRO
                SqlParameter pfiltro;
                pfiltro = da.SelectCommand.Parameters.Add("@filtro", SqlDbType.Text);
                pfiltro.Value = filtro;
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro servidor SQL: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
