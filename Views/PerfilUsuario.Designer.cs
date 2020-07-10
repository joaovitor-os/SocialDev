using System.Windows.Forms;
using System.Drawing;
using System;

namespace FrontEndHotel
{
    partial class PerfilUsuario
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox pb_Detalhe;        
        private ListView listarPerfil;
        private ColumnHeader nomeUsuario;
        private ColumnHeader UserUsuario;
        private ColumnHeader SenhaUsuario;
        private ColumnHeader EmailUsuario;
        private ColumnHeader DescricaoUsuario;
        private ColumnHeader CidadeUsuario;
        private Button btnAlterar;
        private Button btnExcluir;
        private Button btnVoltar;

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
            // PictureBox
            this.pb_Detalhe = new Library.PictureBox();
            this.pb_Detalhe.Load("./Views/assets/image.png");
            this.pb_Detalhe.Location = new Point(130, 20);
            this.Controls.Add(pb_Detalhe);
            
            this.listarPerfil = new ListView();
            this.nomeUsuario = ((ColumnHeader)(new ColumnHeader()));
            this.UserUsuario = ((ColumnHeader)(new ColumnHeader()));
            this.SenhaUsuario = ((ColumnHeader)(new ColumnHeader()));
            this.EmailUsuario = ((ColumnHeader)(new ColumnHeader()));
            this.DescricaoUsuario = ((ColumnHeader)(new ColumnHeader()));
            this.CidadeUsuario = ((ColumnHeader)(new ColumnHeader()));
            this.SuspendLayout();
            // 
            // listar reserva
            // 
            this.listarPerfil.CheckBoxes = true;
            this.listarPerfil.Columns.AddRange(new ColumnHeader[] {
            this.nomeUsuario,
            this.UserUsuario,
            this.SenhaUsuario,
            this.EmailUsuario,
            this.DescricaoUsuario,
            this.CidadeUsuario});
            this.listarPerfil.HideSelection = false;
            this.listarPerfil.Location = new Point(85, 100);
            this.listarPerfil.Name = "Perfil Usuário";
            this.listarPerfil.Size = new Size(280, 150);
            this.listarPerfil.UseCompatibleStateImageBehavior = false;
            // 
            // nome usuario
            // 
            this.nomeUsuario.Text = "Nome do Usuário";
            this.nomeUsuario.TextAlign = HorizontalAlignment.Center;
            this.nomeUsuario.Width = 115;
            // 
            // user
            // 
            this.UserUsuario.Text = "User";
            this.UserUsuario.TextAlign = HorizontalAlignment.Center;
            this.UserUsuario.Width = 100;
            //
            // senha
            //
            this.SenhaUsuario.Text = "Senha";
            this.SenhaUsuario.TextAlign = HorizontalAlignment.Center;
            this.SenhaUsuario.Width = 100;
            // 
            // email
            // 
            this.EmailUsuario.Text = "Email";
            this.EmailUsuario.TextAlign = HorizontalAlignment.Center;
            this.EmailUsuario.Width = 100;
            // 
            // descricao
            // 
            this.DescricaoUsuario.Text = "Descrição";
            this.DescricaoUsuario.TextAlign = HorizontalAlignment.Center;
            this.DescricaoUsuario.Width = 100;
            // 
            // cidade
            // 
            this.CidadeUsuario.Text = "Cidade";
            this.CidadeUsuario.TextAlign = HorizontalAlignment.Center;
            this.CidadeUsuario.Width = 100;
            // 
            // btnAlterar
            // 
            this.btnAlterar = new Library.Button();
            this.btnAlterar.BackColor = ColorTranslator.FromHtml("#FF87CEFA");
            this.btnAlterar.Location = new Point(26, 300);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new EventHandler(this.btnAlterar_Click);
            //
            // btnVoltar
            //
            this.btnVoltar = new Library.Button();
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Location = new Point(156, 300);
            this.btnVoltar.BackColor = ColorTranslator.FromHtml("#FF87CEFA");
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new EventHandler(this.btnVoltarClick);
            this.Controls.Add(btnVoltar);
            // 
            // btnExcluir
            // 
            this.btnExcluir = new Library.Button();
            this.btnExcluir.BackColor = ColorTranslator.FromHtml("#FF87CEFA");
            this.btnExcluir.Location = new Point(286, 300);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new EventHandler(this.btnExcluir_Click);
            // 
            // ListarPerfil
            // 
            this.Name = "Listar Perfil";
            this.Text = "Listar Perfil";
            this.BackColor = ColorTranslator.FromHtml("#FFF0F8FF");
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.ClientSize = new Size(450, 350);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.listarPerfil);
            this.ResumeLayout(false);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}