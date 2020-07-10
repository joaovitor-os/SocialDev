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
    partial class ListaUsuario
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Library.Button btnVoltar;
        private Library.Button btnEnviarEmail;
        private ListView lvListaUsuario;
        private Library.PictureBox pb_Detalhe;
        Form parent;
        #region Windows Form Designer generated code
        private void InitializeComponent(Form parent)
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Text = "Listar Usuario";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = ColorTranslator.FromHtml("#FFF0F8FF");
            this.parent = parent;
            
            this.pb_Detalhe = new Library.PictureBox();
            this.pb_Detalhe.Load("./Views/assets/image.png");
            this.Controls.Add(pb_Detalhe);
            
            this.btnEnviarEmail = new Library.Button();
            this.btnEnviarEmail.Text = "Enviar Email";
            this.btnEnviarEmail.BackColor = ColorTranslator.FromHtml("#FF87CEFA");
            this.btnEnviarEmail.Location = new Point(150, 350);
            this.btnEnviarEmail.Click += new EventHandler(this.btnEnviarEmail_Click);
            this.Controls.Add(btnEnviarEmail);

            this.btnVoltar = new Library.Button();
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.BackColor = ColorTranslator.FromHtml("#FF87CEFA");
            this.btnVoltar.Location = new Point(20, 350);
            this.btnVoltar.Click += new EventHandler(this.btnVoltarClick);
            this.Controls.Add(btnVoltar);

            this.lvListaUsuario = new ListView();
            this.lvListaUsuario.Location = new Point(20, 80);
            this.lvListaUsuario.Size = new Size(260, 250);
            ListViewItem usuarios = new ListViewItem();

            this.lvListaUsuario.MultiSelect = false;
            this.lvListaUsuario.Columns.Add("ID", -2, HorizontalAlignment.Center);
            this.lvListaUsuario.Columns.Add("Nome Usuario", -2, HorizontalAlignment.Left);
            this.lvListaUsuario.Columns.Add("User", -2, HorizontalAlignment.Left);
            this.lvListaUsuario.Columns.Add("Email", -2, HorizontalAlignment.Left);
            this.lvListaUsuario.Columns.Add("Descrição", -2, HorizontalAlignment.Left);
            this.lvListaUsuario.Columns.Add("Cidade", -2, HorizontalAlignment.Center);
            this.Controls.Add(lvListaUsuario);
        }
        #endregion
    }
}