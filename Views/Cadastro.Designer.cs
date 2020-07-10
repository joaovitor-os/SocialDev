using System;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    partial class Cadastro : Form
    {
        // Library com os parâmetros em comum entre os componentes
        Library.PictureBox pb_Imagem;

        Library.Button btn_Usuarios;
        Library.Button btn_ListaUsuarios;
        Library.Button btn_MenuSair;
        Form parent;

        public void InitializeComponent(Form parent)
        {
            // Parêmetros da janela principal dos Cadastros
            this.Text = "Cadastro";
            this.BackColor = Color.LightGray;
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Size = new Size(400, 300);
            this.parent = parent;

            this.pb_Imagem = new Library.PictureBox();
            this.pb_Imagem.Load("./Views/assets/image.png");
            this.Controls.Add(pb_Imagem);

            this.btn_Usuarios = new Library.Button();
            this.btn_Usuarios.Location = new Point(220, 80);
            this.btn_Usuarios.Text = "USUÁRIOS";
            this.Controls.Add(btn_Usuarios);
            this.btn_Usuarios.Click += new EventHandler(btn_UsuariosClick);

            this.btn_ListaUsuarios = new Library.Button();
            this.btn_ListaUsuarios.Location = new Point(115, 140);
            this.btn_ListaUsuarios.Size = new Size(150, 30);
            this.btn_ListaUsuarios.BackColor = Color.DarkGray;
            this.btn_ListaUsuarios.ForeColor = Color.Black;
            this.btn_ListaUsuarios.Text = "LISTA USUÁRIOS";
            this.Controls.Add(btn_ListaUsuarios);
            this.btn_ListaUsuarios.Click += new EventHandler(btn_ListaUsuariosClick);

            this.btn_MenuSair = new Library.Button();
            this.btn_MenuSair.Location = new Point(130, 190);
            this.btn_MenuSair.Text = "SAIR";
            this.Controls.Add(btn_MenuSair);
            this.btn_MenuSair.Click += new EventHandler(btn_MenuSairClick);
        }
    }
}