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
    public class VendasDAL
    {
        public void Incluir(VendasInformation vendas)
        {
            SqlConnection cn = new SqlConnection();
            try
            {

                cn.ConnectionString = Dados.StringDeConexao();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Insere_Vendas";

                //PARAMETROS DA STORED PROCEDURE
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pdata = new SqlParameter("@data", SqlDbType.Date);
                pdata.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pdata);

                SqlParameter pquantidade = new SqlParameter("@quantidade", SqlDbType.Int);
                pquantidade.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pquantidade);

                SqlParameter pfaturado = new SqlParameter("@faturado", SqlDbType.Bit);
                pfaturado.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pfaturado);

                SqlParameter pcodigocliente = new SqlParameter("@codigocliente", SqlDbType.Int);
                pcodigocliente.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigocliente);

                SqlParameter pcodigoproduto = new SqlParameter("@codigoproduto", SqlDbType.Int);
                pcodigoproduto.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigoproduto);

                cn.Open();
                cmd.ExecuteNonQuery();

                vendas.Codigo = (Int32)cmd.Parameters["@codigo"].Value;
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
        public void Alterar(VendasInformation vendas)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Altera_Vendas";

                //PARAMETROS DA STORED PROCEDURE
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pdata = new SqlParameter("@data", SqlDbType.Date);
                pdata.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pdata);

                SqlParameter pquantidade = new SqlParameter("@quantidade", SqlDbType.Int);
                pquantidade.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pquantidade);

                SqlParameter pfaturado = new SqlParameter("@faturado", SqlDbType.Bit);
                pfaturado.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pfaturado);

                SqlParameter pcodigocliente = new SqlParameter("@codigocliente", SqlDbType.Int);
                pcodigocliente.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigocliente);

                SqlParameter pcodigoproduto = new SqlParameter("@codigoproduto", SqlDbType.Int);
                pcodigoproduto.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigoproduto);

                cn.Open();
                cmd.ExecuteNonQuery();

                vendas.Codigo = (Int32)cmd.Parameters["@codigo"].Value;
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
                cmd.CommandText = "Exclui_Vendas";

                //PARAMETROS DO CÓDIGO
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Value = codigo;
                cmd.Parameters.Add(pcodigo);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir a venda" + codigo);
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
                da.SelectCommand.CommandText = "Seleciona_Vendas";
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
