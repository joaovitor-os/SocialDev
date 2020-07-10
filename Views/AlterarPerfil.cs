using System;
using System.Windows.Forms;

namespace FrontEndHotel
{
    public partial class AlterarPerfil : Form
    {
        public AlterarPerfil()
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
            $"Número do Quarto: {tbUserUsuario.Text}\n" +
            $"Data de Entrada: {tbSenhaUsuario.Text}\n" +
            $"Data de Entrada: {tbEmailUsuario.Text}\n" +
            $"Data de Entrada: {tbDescricaoUsuario.Text}\n" +
            $"Previsão de Estadia: {tbCidadeUsuario.Text}\n",
            "Alterar Perfil",
            MessageBoxButtons.OK
           );
        }
    }
}
