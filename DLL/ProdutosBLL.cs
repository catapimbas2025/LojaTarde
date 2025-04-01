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
    public class ProdutosBLL
    {
        public void Incluir(ProdutosInformation produtos)
        {
            //OO NOME DO PRODUTO É OBRIGATÓRIO
            if (produtos.Nome.Trim().Length == 0)

            {
                throw new Exception("O nome do produto é obrigatório");

            }
            //O PREÇO É OBRIGATÓRIO
            if (produtos.Preco < 0)
            {
                throw new Exception("Adicione o preço do produto");
            }
            // O ESTOQUE E OBRIGATÓRIO
            if (produtos.Estoque < 0)
            {
                throw new Exception("O campo estoque deve ser preenchido");
            }
            //SE TUDO ESTIVER CORRRETO, CHAM A ROTINA PARA INSERIR
            ProdutosDAL obj = new ProdutosDAL();
            obj.Incluir(produtos);
        }
        public void Alterar(ProdutosInformation produtos)
        {
            //OO NOME DO PRODUTO É OBRIGATÓRIO
            if (produtos.Nome.Trim().Length == 0)

            {
                throw new Exception("O nome do produto é obrigatório");

            }
            //O PREÇO É OBRIGATÓRIO
            if (produtos.Preco < 0)
            {
                throw new Exception("Adicione o preço do produto");
            }
            // O ESTOQUE E OBRIGATÓRIO
            if (produtos.Estoque < 0)
            {
                throw new Exception("O campo estoque deve ser preenchido");
            }
            //SE TUDO ESTIVER CORRRETO, CHAM A ROTINA PARA INSERIR
            ProdutosDAL obj = new ProdutosDAL();
            obj.Alterar(produtos);
        }
        public void Excluir(int codigo)
        {
            if (codigo < 1)
            {
                throw new Exception("Selecione um produto antes de exclui-lo ");
                ProdutosDAL obj = new ProdutosDAL();
                obj.Excluir(codigo);
            }
        }

        public DataTable Listagem(string filtro)
        {
            ProdutosDAL obj = new ProdutosDAL();
            return obj.Listagem(filtro);
        }
    }
}
