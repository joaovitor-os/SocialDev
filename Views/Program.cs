using System;
using System.Windows.Forms;

namespace SistemaFilipini
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        // Botão de acesso a tela Cadastro do Usuário
        // Nível de Acesso (Usuário Proprietário)
        private void btn_CadastrarUsuarioClick(object sender, EventArgs e)
        {
            CadastrarUsuario cadastrarUsuario = new CadastrarUsuario(this);
            cadastrarUsuario.Show();
        }

        private void btn_ListarUsuarioClick(object sender, EventArgs e)
        {
            ListaUsuario listarUsuario = new ListaUsuario(this);
            listarUsuario.Show();
        }
        // Botão Sair
        private void btn_SairClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

