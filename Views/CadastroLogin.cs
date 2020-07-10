using System;
using Models;
using Controllers;
using System.Windows.Forms;

namespace View
{
    public partial class CadastroLogin : Form
    {
        // Tentativa para distinguir Cadastro e ALteração
        Usuario usuario;
        public CadastroLogin(Form parent, int id = 0)
        {
            try
            {
                usuario = UsuarioController.GetUsuario(id);
            }
            catch
            {

            }
            InitializeComponent(parent, id > 0);
        }

        // Botão Confirma Cadastro ou Alteração do Usuário
        private void btn_ConfirmarClick(object sender, EventArgs e)
        {
            try{
                if (Controllers.UsuarioController.CampoCadastroUsuario(txt_NomeUsuario.Text, txt_Usuario.Text, txt_SenhaUsuario.Text, txt_ConfirmarSenha.Text, txt_EmailUsuario.Text, txt_DescricaoUsuario.Text, txt_CidadeUsuario.Text))
                {

                    UsuarioController.CadastrarUsuario(
                    txt_NomeUsuario.Text,
                    txt_Usuario.Text,
                    txt_SenhaUsuario.Text,
                    txt_EmailUsuario.Text,
                    txt_DescricaoUsuario.Text,
                    txt_CidadeUsuario.Text
                    );
                    MessageBox.Show("Cadastrado Com Sucesso!");
                }
                else
                {
                    UsuarioController.AlterarUsuario(
                    usuario.IdUsuario,
                    txt_NomeUsuario.Text,
                    txt_Usuario.Text,
                    txt_SenhaUsuario.Text,
                    txt_EmailUsuario.Text,
                    txt_DescricaoUsuario.Text,
                    txt_CidadeUsuario.Text
                    );
                    MessageBox.Show("Alterado Com Sucesso!");

                }
                this.Close();
                this.parent.Show();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Preencha todos os campos!");
            }


        // Botão Cancelar Cadastro
        private void btn_CancelarClick(object sender, EventArgs e)
        {
            this.Close();
        }

        // Método para preencher campos para alteração
        private void LoadForm(object sender, EventArgs e)
        {
        this.txt_NomeUsuario.Text = usuario.NomeUsuario;
        this.txt_Usuario.Text = usuario.LoginUsuario;
        this.txt_SenhaUsuario.Text = usuario.SenhaUsuario;
        this.txt_EmailUsuario.Text = usuario.EmailUsuario;
        this.txt_DescricaoUsuario.Text = usuario.DescricaoUsuario;
        this.txt_CidadeUsuario.Text = usuario.CidadeUsuario;
        }
    }
}