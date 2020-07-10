using System;
using System.Windows.Forms;

namespace View
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        // Botão de acesso a tela Cadastro do Usuário
        // Nível de Acesso (Usuário Proprietário)
        private void btn_CadastroClick(object sender, EventArgs e)
        {
            Cadastro cadastroClick = new Cadastro(this);
            cadastroClick.Show();
        }

        // Botão Sair
        private void btn_MenuSairClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
