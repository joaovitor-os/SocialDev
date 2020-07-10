using System;
using System.Drawing;
using System.Windows.Forms;

namespace FrontEndHotel
{
    partial class CadastroUsuario
    {
        private System.ComponentModel.IContainer components = null;
        private Library.PictureBox pb_Imagem;

        private Library.Label lbNomeUsuario;
        private Library.Label lbUserUsuario;
        private Library.Label lbSenhaUsuario;
        private Library.Label lbEmailUsuario;
        private Library.Label lbDescricaoUsuario;
        private Library.Label lbCidadeUsuario;

        private Library.TextBox tbNomeUsuario;
        private Library.TextBox tbUserUsuario;
        private Library.TextBox tbSenhaUsuario;
        private Library.TextBox tbEmailUsuario;
        private Library.TextBox tbDescricaoUsuario;
        private Library.TextBox tbCidadeUsuario;

        private Library.Button btn_Cancelar;
        private Library.Button btn_Salvar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Text = "Cadastrar Usuario";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = ColorTranslator.FromHtml("#FFF0F8FF");

            this.pb_Imagem = new Library.PictureBox();
            this.pb_Imagem.Load("./Views/assets/image.png");
            this.Controls.Add(pb_Imagem);

            this.lbNomeUsuario = new Library.Label();
            this.lbNomeUsuario.Text = "Nome Usuário: ";
            this.lbNomeUsuario.Location = new Point(20, 60);
            this.Controls.Add(lbNomeUsuario);

            this.tbNomeUsuario = new Library.TextBox();
            this.tbNomeUsuario.Location = new Point(20, 85);
            this.Controls.Add(tbNomeUsuario);

            this.lbUserUsuario = new Library.Label();
            this.lbUserUsuario.Text = "User: ";
            this.lbUserUsuario.Location = new Point(20, 110);
            this.Controls.Add(lbUserUsuario);

            this.tbUserUsuario = new Library.TextBox();
            this.tbUserUsuario.Location = new Point(20, 135);
            this.Controls.Add(tbUserUsuario);

            this.lbSenhaUsuario = new Library.Label();
            this.lbSenhaUsuario.Text = "Senha: ";
            this.lbSenhaUsuario.Location = new Point(20, 160);
            this.Controls.Add(lbSenhaUsuario);

            this.tbSenhaUsuario = new Library.TextBox();
            this.tbSenhaUsuario.Location = new Point(20, 185);
            this.Controls.Add(tbSenhaUsuario);

            this.lbEmailUsuario = new Library.Label();
            this.lbEmailUsuario.Text = "Email: ";
            this.lbEmailUsuario.Location = new Point(20, 210);
            this.Controls.Add(lbEmailUsuario);

            this.tbEmailUsuario = new Library.TextBox();
            this.tbEmailUsuario.Location = new Point(20, 235);
            this.Controls.Add(tbEmailUsuario);

            this.lbDescricaoUsuario = new Library.Label();
            this.lbDescricaoUsuario.Text = "Descrição:";
            this.lbDescricaoUsuario.Location = new Point(20, 260);
            this.Controls.Add(lbDescricaoUsuario);

            this.tbDescricaoUsuario = new Library.TextBox();
            this.tbDescricaoUsuario.Location = new Point(20, 285);
            this.Controls.Add(tbDescricaoUsuario);

            this.lbCidadeUsuario = new Library.Label();
            this.lbCidadeUsuario.Text = "Cidade:";
            this.lbCidadeUsuario.Location = new Point(20, 310);
            this.Controls.Add(lbCidadeUsuario);

            this.tbCidadeUsuario = new Library.TextBox();
            this.tbCidadeUsuario.Location = new Point(20, 335);
            this.Controls.Add(tbCidadeUsuario);

            this.btn_Cancelar = new Library.Button();
            this.btn_Cancelar.Text = "CANCELAR";
            this.btn_Cancelar.BackColor = ColorTranslator.FromHtml("#FF87CEFA");
            this.btn_Cancelar.Location = new Point(20, 350);
            this.btn_Cancelar.Click += new EventHandler(this.btn_CancelarClick);
            this.Controls.Add(btn_Cancelar);

            this.btn_Salvar = new Library.Button();
            this.btn_Salvar.Text = "SALVAR";
            this.btn_Salvar.Location = new Point(150, 350);
            this.btn_Salvar.BackColor = ColorTranslator.FromHtml("#FF87CEFA");
            this.btn_Salvar.Click += new EventHandler(this.btn_SalvarClick);
            this.Controls.Add(btn_Salvar);
        }
    }
}
