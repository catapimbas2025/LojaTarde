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
//CREATE BY PEDRO HENRIQUE
namespace BLL
{
    public class ClientesBLL
    {
     //O NOME DO CLIENTE DEVERÁ SER OBRIGATÓRIO
     public void Incluir(ClientesInformation clientes) 
    {
            if (clientes.Nome.Trim().Length == 0)

            {
                throw new Exception("O nome do cliente é obrigatório");

            }
            //O EMAIL É SEMPRE COM LETRAS MINÚSCULAS
            clientes.Email = clientes.Email.ToLower();

            //SE TUDO ESTIVER CORRRETO, CHAM A ROTINA PARA INSERIR
            ClientesDAL obj = new ClientesDAL();
            obj.Incluir(clientes);

     }
        public void Alterar (ClientesInformation clientes)
        {
            if (clientes.Nome.Trim().Length == 0)

            {
                throw new Exception("O nome do cliente é obrigatório");

            }
            //O EMAIL É SEMPRE COM LETRAS MINÚSCULAS
            clientes.Email = clientes.Email.ToLower();

            //SE TUDO ESTIVER CORRRETO, CHAM A ROTINA PARA INSERIR
            ClientesDAL obj = new ClientesDAL();
            obj.Alterar(clientes);

        }
        public void Excluir(int codigo)
        {
            if (codigo < 1)
            {
                throw new Exception("Selecione um cliente antes de exclui-lo ");
                ClientesDAL obj = new ClientesDAL();
                obj.Excluir(codigo); 
            }
        }
        public DataTable Listagem(string filtro)
        {
            ClientesDAL obj = new ClientesDAL();
            return obj.Listagem(filtro); 
        }
    }

    } 