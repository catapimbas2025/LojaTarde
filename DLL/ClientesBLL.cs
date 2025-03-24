using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using DAL;
using Microsoft.Data.SqlClient;
using Microsoft.Data;

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

}

    } 