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
    public partial class EnviarEmail : Form
    {
        public EnviarEmail()
        {
            InitializeComponent();
        }
        public void btnEnviarClick(object sender, EventArgs e){
            MessageBox.Show("Enviado");
        }
        public void btnVoltarClick(object sender, EventArgs e){
            this.Close();
        }
    }
}
