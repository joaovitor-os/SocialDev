using System;
using Models;
using Controllers;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace View
{
    partial class ListaUsuario : Form
    {
        Library.PictureBox pb_Imagem;

        Library.ListView lv_ListaUsuarios;

        Library.Button btn_ListaConsulta;
        Library.Button btn_ListaAlterar;
        Library.Button btn_ListaDeletar;
        Library.Button btn_ListaSair;
        Form parent;
        
        public void InitializeComponent(Form parent)
        {
            // Parêmetros da janela Lista de Usuários
            this.Text = "Lista Usuários";
            this.BackColor = Color.LightGray;
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Size = new Size(400, 380);
            this.parent = parent;

            // Componentes da janela
            this.pb_Imagem = new Library.PictureBox();
            this.pb_Imagem.Load("./Views/assets/image.png");
            this.Controls.Add(pb_Imagem);

            this.lv_ListaUsuarios = new Library.ListView();
            this.lv_ListaUsuarios.Location = new Point(10, 10);
            this.lv_ListaUsuarios.Size = new Size(350, 200);
            ListViewItem usuarios = new ListViewItem();
            List<Usuario> usuariosLista = UsuarioController.GetUsuarios();
            foreach (var usuario in usuariosLista)
            {
                ListViewItem lv_ListaUsuario = new ListViewItem(usuario.IdUsuario.ToString());
                lv_ListaUsuario.SubItems.Add(usuario.NomeUsuario);
                lv_ListaUsuario.SubItems.Add(usuario.LoginUsuario);
                lv_ListaUsuario.SubItems.Add(usuario.SenhaUsuario);
                lv_ListaUsuario.SubItems.Add(usuario.EmailUsuario);
                lv_ListaUsuario.SubItems.Add(usuario.DescricaoUsuario);
                lv_ListaUsuario.SubItems.Add(usuario.CidadeUsuario);
                lv_ListaUsuarios.Items.Add(lv_ListaUsuario);
            }
            this.lv_ListaUsuarios.MultiSelect = false;
            this.lv_ListaUsuarios.Columns.Add("ID", -2, HorizontalAlignment.Center);
            this.lv_ListaUsuarios.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            this.lv_ListaUsuarios.Columns.Add("User", -2, HorizontalAlignment.Center);
            this.lv_ListaUsuarios.Columns.Add("Senha", -2, HorizontalAlignment.Center);
            this.lv_ListaUsuarios.Columns.Add("Email", -2, HorizontalAlignment.Center);
            this.lv_ListaUsuarios.Columns.Add("Descrição", -2, HorizontalAlignment.Center);
            this.lv_ListaUsuarios.Columns.Add("Cidade", -2, HorizontalAlignment.Center);
            this.Controls.Add(lv_ListaUsuarios);

            // 3 Botões de acesso ao CRUD dentro da Lista
            // Consulta (Read), Altera (Update) e Deleta (Delete)
            this.btn_ListaConsulta = new Library.Button();
            this.btn_ListaConsulta.Location = new Point(30, 230);
            this.btn_ListaConsulta.Size = new Size(150, 30);
            this.btn_ListaConsulta.BackColor = Color.LightBlue;
            this.btn_ListaConsulta.ForeColor = Color.Black;
            this.btn_ListaConsulta.Text = "Consultar";
            this.Controls.Add(btn_ListaConsulta);
            this.btn_ListaConsulta.Click += new EventHandler(btn_ListaConsultaClick);

            this.btn_ListaAlterar = new Library.Button();
            this.btn_ListaAlterar.Location = new Point(200, 230);
            this.btn_ListaAlterar.Size = new Size(150, 30);
            this.btn_ListaAlterar.BackColor = Color.Yellow;
            this.btn_ListaAlterar.ForeColor = Color.Black;
            this.btn_ListaAlterar.Text = "Alterar";
            this.Controls.Add(btn_ListaAlterar);
            this.btn_ListaAlterar.Click += new EventHandler(btn_ListaAlterarClick);

            this.btn_ListaDeletar = new Library.Button();
            this.btn_ListaDeletar.Location = new Point(30, 280);
            this.btn_ListaDeletar.Size = new Size(150, 30);
            this.btn_ListaDeletar.BackColor = Color.Red;
            this.btn_ListaDeletar.ForeColor = Color.Black;
            this.btn_ListaDeletar.Text = "Excluir";
            this.Controls.Add(btn_ListaDeletar);
            this.btn_ListaDeletar.Click += new EventHandler(btn_ListaDeletarClick);

            this.btn_ListaSair = new Library.Button();
            this.btn_ListaSair.Location = new Point(200, 280);
            this.btn_ListaSair.Size = new Size(150, 30);
            this.btn_ListaSair.BackColor = Color.Green;
            this.btn_ListaSair.ForeColor = Color.Black;
            this.btn_ListaSair.Text = "Sair";
            this.btn_ListaSair.Click += new EventHandler(btn_ListaSairClick);
            this.Controls.Add(btn_ListaSair);
        }
    }
}