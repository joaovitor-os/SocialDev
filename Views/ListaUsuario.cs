using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEndHotel
{
    public partial class ListaUsuario : Form
    {
        public ListaUsuario()
        {
            InitializeComponent();
        }
        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            EnviarEmail enviarEmail = new EnviarEmail(this);
            enviarEmail.ShowDialog();
        }
        public void btnVoltarClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
