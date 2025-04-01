using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using DAL;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using System.Data;

namespace BLL
{
    public class VendasBLL
    {
        public void Incluir(VendasInformation vendas)
        {
            if (vendas.Data == DateTime.MinValue)
            {
                throw new Exception("A data da venda é obrigatória");
            }

            //A QUANTIDADE DO PRODUTO DEVERÁ SER OBRIGATÓRIA
            if (vendas.Quantidade < 0)
            {
                throw new Exception("A quantidade de produtos é obrigatória");
            }

            // A OPÇÃO "FATURADO" deverá ser obrigatória
            if (vendas.Faturado < 0)
            {
                throw new Exception("Selecione se a compra foi faturada");
            }

            // O CÓDIGO DO CLIENTE DEVERÁ SER OBRIGATÓRIO
            if (vendas.CodigoCliente < 1)
            {
                throw new Exception("Selecione o código do cliente");
            }

            // O CÓDIGO DO PRODUTO DEVERÁ SER OBRIGATÓRIO
            if (vendas.CodigoProduto < 1)
            {
                throw new Exception("Selecione o código do produto");
            }

            //SE TUDO ESTIVER CORRRETO, CHAM A ROTINA PARA INSERIR
            VendasDAL obj = new VendasDAL();
            obj.Incluir(vendas);




        }
        public void Alterar(VendasInformation vendas)
        {
            if (vendas.Data == DateTime.MinValue)
            {
                throw new Exception("A data da venda é obrigatória");
            }

            //A QUANTIDADE DO PRODUTO DEVERÁ SER OBRIGATÓRIA
            if (vendas.Quantidade < 0)
            {
                throw new Exception("A quantidade de produtos é obrigatória");
            }

            // A OPÇÃO "FATURADO" deverá ser obrigatória
            if (vendas.Faturado < 0)
            {
                throw new Exception("Selecione se a compra foi faturada");
            }

            // O CÓDIGO DO CLIENTE DEVERÁ SER OBRIGATÓRIO
            if (vendas.CodigoCliente < 1)
            {
                throw new Exception("Selecione o código do cliente");
            }

            // O CÓDIGO DO PRODUTO DEVERÁ SER OBRIGATÓRIO
            if (vendas.CodigoProduto < 1)
            {
                throw new Exception("Selecione o código do produto");
            }

            //SE TUDO ESTIVER CORRRETO, CHAM A ROTINA PARA INSERIR
            VendasDAL obj = new VendasDAL();
            obj.Alterar(vendas);
        }
        public void Excluir(int codigo)
        {
            if (codigo < 1)
            {
                throw new Exception("Selecione uma venda antes de exclui-lo ");
                VendasDAL obj = new VendasDAL();
                obj.Excluir(codigo);
            }
        }
        public DataTable Listagem(string filtro)
        {
            VendasDAL obj = new VendasDAL();
            return obj.Listagem(filtro);
        }
    }
}
