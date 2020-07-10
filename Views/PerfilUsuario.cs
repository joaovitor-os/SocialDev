using System;
using System.Windows.Forms;

namespace FrontEndHotel
{
    public partial class PerfilUsuario : Form
    {
        public PerfilUsuario()
        {
            InitializeComponent();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarPerfil alterarPerfil = new AlterarPerfil();
            alterarPerfil.Show();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExclusaoPerfil excluirPerfil = new ExclusaoPerfil(this);
            excluirPerfil.ShowDialog();
        }
        public void btnVoltarClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}