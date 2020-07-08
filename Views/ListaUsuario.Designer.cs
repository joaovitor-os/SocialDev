using System;
using Models;
using Controllers;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SistemaFilipini
{
    partial class ListaUsuario : Form
    {
        private ListView lv_ListaUsuarios;
        private Button btn_ListaConsultar;
        private Button btn_ListaAlterar;
        private Button btn_ListaExcluir;
        private Button btn_ListaSair;
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
            this.lv_ListaUsuarios = new ListView();
            this.lv_ListaUsuarios.Location = new Point(10, 10);
            this.lv_ListaUsuarios.Size = new Size(350, 200);
            ListViewItem usuarios = new ListViewItem();
            List<Usuario> usuariosLista = UsuarioController.GetUsuarios();
            foreach (var usuario in usuariosLista)
            {
                ListViewItem lv_ListaUsuario = new ListViewItem(usuario.IdUsuario.ToString());
                lv_ListaUsuario.SubItems.Add(usuario.NomeUsuario);
                lv_ListaUsuario.SubItems.Add(usuario.EmailUsuario);
                lv_ListaUsuario.SubItems.Add(usuario.DescricaoUsuario);
                lv_ListaUsuario.SubItems.Add(usuario.NascimentoUsuario);
                lv_ListaUsuario.SubItems.Add(usuario.EstadoUsuario);
                lv_ListaUsuario.SubItems.Add(usuario.CidadeUsuario);
                lv_ListaUsuarios.Items.Add(lv_ListaUsuario);
            }
            this.lv_ListaUsuarios.MultiSelect = false;
            this.lv_ListaUsuarios.Columns.Add("ID", -2, HorizontalAlignment.Center);
            this.lv_ListaUsuarios.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            this.lv_ListaUsuarios.Columns.Add("Email", -2, HorizontalAlignment.Center);
            this.lv_ListaUsuarios.Columns.Add("Descrição", -2, HorizontalAlignment.Center);
            this.lv_ListaUsuarios.Columns.Add("Nascimento", -2, HorizontalAlignment.Center);
            this.lv_ListaUsuarios.Columns.Add("Estado", -2, HorizontalAlignment.Center);
            this.lv_ListaUsuarios.Columns.Add("Cidade", -2, HorizontalAlignment.Center);
            this.Controls.Add(lv_ListaUsuarios);

            // 3 Botões de acesso ao CRUD dentro da Lista
            // Consulta (Read), Altera (Update) e Deleta (Delete)
            this.btn_ListaConsultar = new Button();
            this.btn_ListaConsultar.Location = new Point(30, 230);
            this.btn_ListaConsultar.Size = new Size(150, 30);
            this.btn_ListaConsultar.BackColor = Color.LightBlue;
            this.btn_ListaConsultar.ForeColor = Color.Black;
            this.btn_ListaConsultar.Text = "CONSULTA";
            this.Controls.Add(btn_ListaConsultar);
            this.btn_ListaConsultar.Click += new EventHandler(btn_ListaConsultarClickr);

            this.btn_ListaAlterar = new Button();
            this.btn_ListaAlterar.Location = new Point(200, 230);
            this.btn_ListaAlterar.Size = new Size(150, 30);
            this.btn_ListaAlterar.BackColor = Color.Yellow;
            this.btn_ListaAlterar.ForeColor = Color.Black;
            this.btn_ListaAlterar.Text = "ALTERAR";
            this.Controls.Add(btn_ListaAlterar);
            this.btn_ListaAlterar.Click += new EventHandler(btn_ListaAlterarClick);

            this.btn_ListaExcluir = new Button();
            this.btn_ListaExcluir.Location = new Point(30, 280);
            this.btn_ListaExcluir.Size = new Size(150, 30);
            this.btn_ListaExcluir.BackColor = Color.Red;
            this.btn_ListaExcluir.ForeColor = Color.Black;
            this.btn_ListaExcluir.Text = "EXCLUIR";
            this.Controls.Add(btn_ListaExcluir);
            this.btn_ListaExcluir.Click += new EventHandler(btn_ListaExcluirClick);

            this.btn_ListaSair = new Button();
            this.btn_ListaSair.Location = new Point(200, 280);
            this.btn_ListaSair.Size = new Size(150, 30);
            this.btn_ListaSair.BackColor = Color.Green;
            this.btn_ListaSair.ForeColor = Color.Black;
            this.btn_ListaSair.Text = "SAIR";
            this.btn_ListaSair.Click += new EventHandler(btn_ListaSairClick);
            this.Controls.Add(btn_ListaSair);
        }
    }
}