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
    partial class LoginUsuario
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
        private Library.Label lbUser;
        private Library.Label lbSenha;

        private Library.TextBox tbUser;
        private Library.TextBox tbSenha;

        private Library.Button btnLogar;
        private Library.Button btnCadastrar;
        private Library.Button btnSair;
        private Library.Button btnListar;
        private PictureBox pb_Detalhe;
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Text = "SocialDev";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = ColorTranslator.FromHtml("#FFF0F8FF");

            this.pb_Detalhe = new Library.PictureBox();
            this.pb_Detalhe.Load("./Views/assets/image.png");
            this.pb_Detalhe.Location = new Point(200, 20);
            this.Controls.Add(pb_Detalhe);

            this.lbUser = new Library.Label();
            this.lbUser.Text = "User: ";
            this.lbUser.Location = new Point(156, 110);
            this.Controls.Add(lbUser);

            this.tbUser = new Library.TextBox();
            this.tbUser.Location = new Point(156, 135);
            this.Controls.Add(tbUser);

            this.lbSenha = new Library.Label();
            this.lbSenha.Text = "Senha: ";
            this.lbSenha.Location = new Point(156, 160);
            this.Controls.Add(lbSenha);

            this.tbSenha = new Library.TextBox();
            this.tbSenha.Location = new Point(156, 185);
            this.Controls.Add(tbSenha);

            this.btnSair = new Library.Button();
            this.btnSair.Text = "Sair";
            this.btnSair.BackColor = ColorTranslator.FromHtml("#FF87CEFA");
            this.btnSair.Location = new Point(26, 300);
            this.btnSair.Click += new EventHandler(this.btnSairClick);
            this.Controls.Add(btnSair);

            this.btnListar = new Library.Button();
            this.btnListar.Text = "Listar Usuarios";
            this.btnListar.BackColor = ColorTranslator.FromHtml("#FF87CEFA");
            this.btnListar.Location = new Point(286, 300);
            this.btnListar.Click += new EventHandler(this.btnListarUsuarioClick);
            this.Controls.Add(btnListar);

            this.btnCadastrar = new Library.Button();
            this.btnCadastrar.Text = "Cadastra-se";
            this.btnCadastrar.BackColor = ColorTranslator.FromHtml("#FF87CEFA");
            this.btnCadastrar.Location = new Point(156, 300);
            this.btnCadastrar.Click += new EventHandler(this.btnCadastrarClick);
            this.Controls.Add(btnCadastrar);

            this.btnLogar = new Library.Button();
            this.btnLogar.Text = "Logar";
            this.btnLogar.BackColor = ColorTranslator.FromHtml("#FF87CEFA");
            this.btnLogar.Location = new Point(156, 210);
            this.btnLogar.Click += new EventHandler(this.btnLogarClick);
            this.Controls.Add(btnLogar);
        }
    }
    #endregion
}
