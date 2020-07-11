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
            try
            {
                if (Controllers.UsuarioController.CamposPreenchidosCadastroUsuario(txt_NomeUsuario.Text, txt_Email.Text, txt_SenhaUsuario.Text, txt_ConfirmarSenha.Text, txt_Descricao.Text, txt_Github.Text, txt_linkedin.Text))
                {
                    if (Controllers.UsuarioController.ConfirmarSenhasIguais(txt_SenhaUsuario.Text, txt_ConfirmarSenha.Text))
                    {
                        if (usuario == null)
                        {
                            UsuarioController.CadastrarUsuario(
                            txt_NomeUsuario.Text,
                            txt_Email.Text,
                            txt_SenhaUsuario.Text,
                            txt_Descricao.Text,
                            txt_Github.Text,
                            txt_linkedin.Text
                            );
                            MessageBox.Show("Cadastrado Com Sucesso!");
                        }
                        else
                        {
                            UsuarioController.AlterarUsuario(
                            usuario.IdUsuario,
                            txt_NomeUsuario.Text,
                            txt_Email.Text,
                            txt_SenhaUsuario.Text,
                            txt_Descricao.Text == "Usuário Proprietário"
                                ? "Proprietario"
                                : txt_Descricao.Text == "Usuário Funcionário"
                                    ? "Funcionario"
                                    : "Fornecedor"
                        
                           );
                            MessageBox.Show("Alterado Com Sucesso!");

                        }
                        this.Close();
                        this.parent.Show();
                    }
                    else
                    {
                        MessageBox.Show("As Senhas São Diferentes!");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha Todos Os Campos!");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Preencha Todos Os Campos!");
            }
        }
         private void btn_CancelarClick(object sender, EventArgs e)
        {
            this.Close();
        }

        // Método para preencher campos para alteração
        private void LoadForm(object sender, EventArgs e)
        {
            this.txt_NomeUsuario.Text = usuario.NomeUsuario;
            this.txt_Email.Text = usuario.Email;
            this.txt_SenhaUsuario.Text = usuario.SenhaUsuario;
            this.txt_Descricao.Text= usuario.Descricao;
        }
    }
}