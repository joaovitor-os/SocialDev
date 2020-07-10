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
    partial class EnviarEmail
    {
        private System.ComponentModel.IContainer components = null;
        private Library.PictureBox pb_Detalhe;

        private Library.Label lbEmailRemetente;
        private Library.Label lbEmailDestinatario;
        private Library.Label lbSenhaRemetente;
        private Library.Label lbEmailCampo;
        
        private Library.TextBox tbEmailRemetente;
        private Library.TextBox tbEmailDestinatario;
        private Library.TextBox tbSenhaRemetente;
        private Library.TextBox tbEmailCampo;

        private Button btnVoltar;
        private Button btnEnviar;

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
            this.Text = "Enviar Email";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = ColorTranslator.FromHtml("#FFF0F8FF");

            this.pb_Detalhe = new Library.PictureBox();
            this.pb_Detalhe.Load("./Views/assets/image.png");
            this.pb_Detalhe.Location = new Point(200, 20);
            this.Controls.Add(pb_Detalhe);

            this.lbEmailRemetente = new Library.Label();
            this.lbEmailRemetente.Text = "De: ";
            this.lbEmailRemetente.Location = new Point(20, 60);
            this.Controls.Add(lbEmailRemetente);

            this.tbEmailRemetente = new Library.TextBox();
            this.tbEmailRemetente.Location = new Point(20, 85);
            this.Controls.Add(tbEmailRemetente);

            this.lbSenhaRemetente = new Library.Label();
            this.lbSenhaRemetente.Text = "Senha: ";
            this.lbSenhaRemetente.Location = new Point(20, 110);
            this.Controls.Add(lbSenhaRemetente);

            this.tbSenhaRemetente = new Library.TextBox();
            this.tbSenhaRemetente.Location = new Point(20, 135);
            this.Controls.Add(tbSenhaRemetente);

            this.lbEmailDestinatario = new Library.Label();
            this.lbEmailDestinatario.Text = "Para: ";
            this.lbEmailDestinatario.Location = new Point(20, 160);
            this.Controls.Add(lbEmailDestinatario);

            this.tbEmailDestinatario = new Library.TextBox();
            this.tbEmailDestinatario.Location = new Point(20, 185);
            this.Controls.Add(tbEmailDestinatario);

            this.lbEmailCampo = new Library.Label();
            this.lbEmailCampo.Text = "Campo: ";
            this.lbEmailCampo.Location = new Point(20, 210);
            this.Controls.Add(lbEmailCampo);

            this.tbEmailCampo = new Library.TextBox();
            this.tbEmailCampo.Location = new Point(20, 235);
            this.Controls.Add(tbEmailCampo);

            this.btnEnviar = new Button();
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.BackColor = ColorTranslator.FromHtml("#FF87CEFA");
            this.btnEnviar.Size = new Size(130, 40);
            this.btnEnviar.Location = new Point(155, 350);
            this.btnEnviar.Click += new EventHandler(this.btnEnviarClick);
            this.Controls.Add(btnEnviar);

            this.btnVoltar = new Button();
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.BackColor = ColorTranslator.FromHtml("#FF87CEFA");
            this.btnVoltar.Size = new Size(130, 40);
            this.btnVoltar.Location = new Point(15, 350);
            this.btnVoltar.Click += new EventHandler(this.btnVoltarClick);
            this.Controls.Add(btnVoltar);
        }
        
    }
}
