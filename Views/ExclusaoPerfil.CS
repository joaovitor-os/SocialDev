using System;
using System.Windows.Forms;

namespace FrontEndHotel
{
    public partial class ExclusaoPerfil : Form
    {
        public ExclusaoPerfil(Form parent)
        {
            InitializeComponent(parent);
        }
        public void btnExcluirClick(object sender, EventArgs e)
        {
            MessageBox.Show("Excluido!");
        }
        public void btnVoltarClick(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }
    }
}