using System;
using Models;
using Controllers;
using System.Windows.Forms;

namespace SistemaFilipini
{
    public partial class ListaUsuario : Form
    {
        public ListaUsuario(Form parent)
        {
            InitializeComponent(parent);
        }

        // CRUD
        // Consulta Usuário na Lista
        private void btn_ListaClick(object sender, EventArgs e)
        {
            try
            {
                int IdUsuario = Int32.Parse(this.lv_ListaUsuarios.SelectedItems[0].Text);
                Usuario usuario = UsuarioController.GetUsuario(IdUsuario);
                MessageBox.Show(
                $"---[ Dados do Usuário ]---------------------------\n" +
                $"Nome: {usuario.NomeUsuario}\n" +
                $"Email: {usuario.EmailUsuario}\n" +
                $"Descrição: {usuario.DescricaoUsuario}\n" +
                $"Nascimento: {usuario.NascimentoUsuario}\n" +
                $"Estado: {usuario.EstadoUsuario}\n" +
                $"Cidade: {usuario.CidadeUsuario}\n" +
                $"-------------------------------------------------------\n",
                "Consulta Cliente",
                MessageBoxButtons.OK
                );
            }
            catch
            {
                MessageBox.Show("Selecione Um Usuário!");
            }
        }

        // Botão e Método de Alteração de um Usuário da Lista
        private void btn_ListaAlterarClick(object sender, EventArgs e)
        {
            try
            {
                int IdUsuario = Int32.Parse(this.lv_ListaUsuarios.SelectedItems[0].Text);
                CadastrarUsuario btn_UpdateUsuarioClick = new CadastrarUsuario(this, IdUsuario);
                btn_UpdateUsuarioClick.Show();
            }
            catch
            {
                MessageBox.Show("Selecione Um Usuário!");
            }
        }

        // Botão e Método de Deleção de um Usuário da Lista
        private void btn_ListaDeletarClick(object sender, EventArgs e)
        {
            try
            {
                int IdUsuario = Int32.Parse(this.lv_ListaUsuarios.SelectedItems[0].Text);
                DialogResult result = MessageBox.Show("Deseja Exluir Esse Usuário?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        UsuarioController.DeletarUsuario(IdUsuario);
                        this.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Selecione Um Usuário!");
            }
        }

        // Botão Sair
        private void btn_ListaSairClick(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }
    }
}