using System;
using Models;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    partial class Menu : Form
    {
        Library.PictureBox pb_Imagem;

        Library.Button btn_Cadastro;
        Library.Button btn_MenuSair;

        public void InitializeComponent()
        {
            // Parêmetros da janela principal do sistema
            this.Text = "Social Dev";
            this.BackColor = Color.Gray;
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Size = new Size(400, 320);

            // Componentes da janela
            this.pb_Imagem = new Library.PictureBox();
            this.pb_Imagem.Load("./Views/assets/image.png");
            this.Controls.Add(pb_Imagem);

            this.btn_Cadastro = new Library.Button();
            this.btn_Cadastro.Location = new Point(40, 90);
            this.btn_Cadastro.Text = "CADASTRO";
            this.Controls.Add(btn_Cadastro);
            this.btn_Cadastro.Click += new EventHandler(btn_CadastroClick);

            this.btn_MenuSair = new Library.Button();
            this.btn_MenuSair.Location = new Point(130, 210);
            this.btn_MenuSair.Text = "SAIR";
            this.Controls.Add(btn_MenuSair);
            this.btn_MenuSair.Click += new EventHandler(btn_MenuSairClick);
        }
    }
}
