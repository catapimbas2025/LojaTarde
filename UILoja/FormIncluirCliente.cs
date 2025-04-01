using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Modelos;

namespace UILoja
{
    public partial class FormIncluirCliente : Form
    {
        public FormIncluirCliente()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefone.Text = string.Empty;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
             ClientesInformation clientes = new ClientesInformation();
                clientes.Nome = txtNome.Text;
                clientes.Email = txtEmail.Text;
                clientes.Telefone = txtTelefone.Text;

                ClientesBLL obj = new ClientesBLL();
                obj.Incluir(clientes);
                MessageBox.Show("Cliente incluido com sucesso !");


            }
            catch (Exception ex)
            {
             MessageBox.Show(ex.Message);

            throw;
            }
        }
    }
}
