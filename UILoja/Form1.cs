namespace UILoja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adicionaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIncluirCliente frmCliente = new FormIncluirCliente();
           frmCliente.ShowDialog();
            
        }
    }
}
