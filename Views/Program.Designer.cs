using System;
using Models;
using System.Drawing;
using System.Windows.Forms;

namespace SocialDevv
{
    partial class Program : Form
    {
        private PictureBox pb_Logo;
        private Button btn_Cadastrar;
        private Button btn_Listar;
        private Button btn_Sair;

        public void InitializeComponent()
        {
            // Parêmetros da janela principal do sistema
            this.Text = "SOCIAL DEV";
            this.BackColor = Color.Gray;
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Size = new Size(400, 320);

            // Componentes da janela
            // Abaixo, inserindo a imagem na janela
            this.pb_Logo = new PictureBox();
            this.pb_Logo.Load($"./Views/assets/embutidos.jpg");
            this.Controls.Add(pb_Logo);

            this.btn_Cadastrar = new Button();
            this.btn_Cadastrar.Location = new Point(40, 90);
            this.btn_Cadastrar.Text = "CADASTRAR";
            this.Controls.Add(btn_Cadastrar);
            this.btn_Cadastrar.Click += new EventHandler(btn_CadastrarUsuarioClick);

            this.btn_Listar = new Button();
            this.btn_Listar.Location = new Point(40, 90);
            this.btn_Listar.Text = "CADASTRAR";
            this.Controls.Add(btn_Cadastrar);
            this.btn_Listar.Click += new EventHandler(btn_ListarUsuarioClick);

            this.btn_Sair = new Button();
            this.btn_Sair.Location = new Point(130, 210);
            this.btn_Sair.Text = "SAIR";
            this.Controls.Add(btn_Sair);
            this.btn_Sair.Click += new EventHandler(btn_SairClick);
        }
    }
}