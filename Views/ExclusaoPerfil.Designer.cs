using System;
using System.Drawing;
using System.Windows.Forms;

namespace FrontEndHotel
{
    partial class ExclusaoPerfil
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
        private Library.Label lbPergunta;
        private Button btnVoltar;
        private Button btnExcluir;
        Form parent;
        #region Windows Form Designer generated code
        private void InitializeComponent(Form parent)
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 100);
            this.Text = "Exclusão";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.parent = parent;

            this.lbPergunta = new Library.Label();
            this.lbPergunta.Text = ("Deseja excluir perfil?");
            this.lbPergunta.Location = new Point(20, 10);
            this.lbPergunta.Font = new Font(this.Font.FontFamily, 17, FontStyle.Bold);
            this.Controls.Add(lbPergunta);

            this.btnExcluir = new Button();
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.BackColor = ColorTranslator.FromHtml("#FF87CEFA");
            this.btnExcluir.Size = new Size(130, 40);
            this.btnExcluir.Location = new Point(155, 50);
            this.btnExcluir.Click += new EventHandler(this.btnExcluirClick);
            this.Controls.Add(btnExcluir);

            this.btnVoltar = new Button();
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.BackColor = ColorTranslator.FromHtml("#FF87CEFA");
            this.btnVoltar.Size = new Size(130, 40);
            this.btnVoltar.Location = new Point(15, 50);
            this.btnVoltar.Click += new EventHandler(this.btnVoltarClick);
            this.Controls.Add(btnVoltar);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        #endregion
    }
}