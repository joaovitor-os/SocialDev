using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaFilipini
{
    partial class CadastrarUsuario : Form
    {
        private Label lb_NomeUsuario;
        private Label lb_email;
        private Label lb_Dtnasc;
        private Label lb_descricao;
        private Label lb_estado;
        private Label lb_cidade;

        private TextBox txt_NomeUsuario;
        private TextBox txt_email;
        private TextBox txt_Dtnasc;
        private TextBox txt_descricao;
        private TextBox txt_estado;
        private TextBox txt_cidade;
        private Button btn_Confirmar;
        private Button btn_Cancelar;
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
            this.lb_NomeUsuario = new Label();
            this.lb_NomeUsuario.Text = "Nome Usuário:";
            this.lb_NomeUsuario.Location = new Point(20, 20);
            this.Controls.Add(lb_NomeUsuario);

            this.txt_NomeUsuario = new TextBox();
            this.txt_NomeUsuario.Location = new Point(150, 20);
            this.Controls.Add(txt_NomeUsuario);

            this.lb_email = new Label();
            this.lb_email.Text = "Email :";
            this.lb_email.Location = new Point(20, 140);
            this.Controls.Add(lb_email);

            this.txt_email = new TextBox();
            this.txt_email.Location = new Point(150, 80);
            this.Controls.Add(txt_email);

            this.lb_descricao = new Label();
            this.lb_descricao.Text = "Descrição :";
            this.lb_descricao.Location = new Point(20, 140);
            this.Controls.Add(lb_descricao);

            this.txt_descricao = new TextBox();
            this.txt_descricao.Location = new Point(150, 80);
            this.Controls.Add(txt_descricao);

            this.lb_Dtnasc = new Label();
            this.lb_Dtnasc.Text = "Nascimento :";
            this.lb_Dtnasc.Location = new Point(20, 140);
            this.Controls.Add(lb_Dtnasc);

            this.txt_Dtnasc = new TextBox();
            this.txt_Dtnasc.Location = new Point(150, 80);
            this.Controls.Add(txt_Dtnasc);

            this.lb_estado = new Label();
            this.lb_estado.Text = "Estado :";
            this.lb_estado.Location = new Point(20, 140);
            this.Controls.Add(lb_estado);

            this.txt_estado = new TextBox();
            this.txt_estado.Location = new Point(150, 80);
            this.Controls.Add(txt_estado);

            this.lb_cidade = new Label();
            this.lb_cidade.Text = "Cidade :";
            this.lb_cidade.Location = new Point(20, 140);
            this.Controls.Add(lb_cidade);

            this.txt_cidade = new TextBox();
            this.txt_cidade.Location = new Point(150, 80);
            this.Controls.Add(txt_cidade);

            this.btn_Confirmar = new Button();
            this.btn_Confirmar.Text = "CONFIRMAR";
            this.btn_Confirmar.Location = new Point(60, 190);
            this.btn_Confirmar.Click += new EventHandler(this.btn_ConfirmarClick);
            this.Controls.Add(btn_Confirmar);

            this.btn_Cancelar = new Button();
            this.btn_Cancelar.Text = "CANCELAR";
            this.btn_Cancelar.Location = new Point(200, 190);
            this.btn_Cancelar.Click += new EventHandler(this.btn_CancelarClick);
            this.Controls.Add(btn_Cancelar);
        }
    }
}