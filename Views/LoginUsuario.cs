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
    public partial class LoginUsuario : Form
    {
        public LoginUsuario()
        {
            InitializeComponent();
        }
        public void btnSairClick(object sender, EventArgs e)
        {
            this.Close();
        }
        public void btnLogarClick(object sender, EventArgs e)
        {
            
        }
        
        public void btnListarUsuarioClick(object sender, EventArgs e)
        {
            this.Hide();
            ListaUsuario ListarUsuario = new ListaUsuario(this);
            ListarUsuario.Show();
        }

        public void btnCadastrarClick(object sender, EventArgs e)
        {
            this.Hide();
            CadastroUsuario CadastrarUsuario = new CadastroUsuario();
            CadastrarUsuario.Show();
        }
    }
}
