using System;
using System.Windows.Forms;

namespace FrontEndHotel
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }
        private void btn_CancelarClick(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_SalvarClick(object sender, EventArgs e)
        {
            MessageBox.Show(
            $"Nome do Usuário: {tbNomeUsuario.Text}\n" +
            $"User: {tbUserUsuario.Text}\n" +
            $"Email: {tbEmailUsuario.Text}\n" +
            $"Cidade: {tbCidadeUsuario.Text}\n",
            "Cadastro do Usuario",
            MessageBoxButtons.OK
            );
        }
    }
}
