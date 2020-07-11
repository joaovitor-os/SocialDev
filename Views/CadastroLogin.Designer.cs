using System;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    partial class CadastroLogin : Form
    {
        Library.PictureBox pb_Imagem;

        Library.Label lbl_NomeUsuario;
        Library.Label lbl_Email;
        Library.Label lbl_SenhaUsuario;
        Library.Label lbl_Descricao;
        Library.Label lbl_CidadeUsuario;

        Library.TextBox txt_NomeUsuario;
        Library.TextBox txt_Email;
        Library.TextBox txt_SenhaUsuario;
        Library.TextBox txt_Descricao;
        Library.TextBox txt_CidadeUsuario;

        Library.Button btn_Confirmar;
        Library.Button btn_Cancelar;

        Form parent;

        public void InitializeComponent(Form parent, bool isUpdate)
        {
            // Parêmetros da janela Cadastro Usuário
            this.Text = "Cadastro Usuário";
            this.BackColor = Color.LightGray;
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Size = new Size(400, 300);
            this.parent = parent;

            // Tratativa para evento do LoadForm (Alterção) 
            if (isUpdate)
            {
                this.Load += new EventHandler(this.LoadForm);
            }

            // Componentes da janela

            this.pb_Imagem = new Library.PictureBox();
            this.pb_Imagem.Load("./Views/assets/image.png");
            this.Controls.Add(pb_Imagem);

            this.lbl_NomeUsuario = new Library.Label();
            this.lbl_NomeUsuario.Text = "Nome:";
            this.lbl_NomeUsuario.Location = new Point(20, 20);
            this.Controls.Add(lbl_NomeUsuario);

            this.txt_NomeUsuario = new Library.TextBox();
            this.txt_NomeUsuario.Location = new Point(150, 20);
            this.Controls.Add(txt_NomeUsuario);

            this.lbl_Email = new Library.Label();
            this.lbl_Email.Text = "Usuário :";
            this.lbl_Email.Location = new Point(20, 50);
            this.Controls.Add(lbl_Email);

            this.txt_Email = new Library.TextBox();
            this.txt_Email.Location = new Point(150, 50);
            this.Controls.Add(txt_Email);

            this.lbl_SenhaUsuario = new Library.Label();
            this.lbl_SenhaUsuario.Text = "Senha :";
            this.lbl_SenhaUsuario.Location = new Point(20, 80);
            this.Controls.Add(lbl_SenhaUsuario);

            this.txt_SenhaUsuario = new Library.TextBox();
            this.txt_SenhaUsuario.Location = new Point(150, 80);
            this.Controls.Add(txt_SenhaUsuario);

            this.lbl_Descricao = new Library.Label();
            this.lbl_Descricao.Text = "Descrição :";
            this.lbl_Descricao.Location = new Point(20, 110);
            this.Controls.Add(lbl_Descricao);

            this.txt_Descricao = new Library.TextBox();
            this.txt_Descricao.Location = new Point(150, 50);
            this.Controls.Add(txt_Descricao);

            this.lbl_CidadeUsuario = new Library.Label();
            this.lbl_CidadeUsuario.Text = "Confirmar Senha :";
            this.lbl_CidadeUsuario.Location = new Point(20, 110);
            this.Controls.Add(lbl_CidadeUsuario);

            this.txt_CidadeUsuario = new Library.TextBox();
            this.txt_CidadeUsuario.Location = new Point(150, 50);
            this.Controls.Add(txt_CidadeUsuario);

            this.btn_Confirmar = new Library.Button();
            this.btn_Confirmar.Text = "CONFIRMAR";
            this.btn_Confirmar.Location = new Point(60, 190);
            this.btn_Confirmar.Click += new EventHandler(this.btn_ConfirmarClick);
            this.Controls.Add(btn_Confirmar);

            this.btn_Cancelar = new Library.Button();
            this.btn_Cancelar.Text = "CANCELAR";
            this.btn_Cancelar.Location = new Point(200, 190);
            this.btn_Cancelar.Click += new EventHandler(this.btn_CancelarClick);
            this.Controls.Add(btn_Cancelar);
        }
    }
}