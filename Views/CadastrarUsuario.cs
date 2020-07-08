using System;
using Models;
using Controllers;
using System.Windows.Forms;

namespace SocialDevv
{
    public partial class CadastrarUsuario : Form
    {
        // Tentativa para distinguir Cadastro e ALteração
        Usuario usuario;
        public CadastrarUsuario(Form parent, int id = 0)
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

        // Botão Confirma Cadastro 
        private void btn_ConfirmarClick(object sender, EventArgs e)
        {
            try
            {
                UsuarioController.CadastrarUsuario(txt_NomeUsuario.Text, txt_email.Text, txt_descricao.Text, txt_DtNasc.Text, txt_estado.Text, txt_cidade.Text))
                MessageBox.Show(
                $"Nome: {txtNomeUsuario.Text}\n" +
                $"Email: {txt_email.Text}\n" +
                $"Descrição: {txt_descrcao.Text}\n" +
                $"Data Nasci: {txt_Dtnasc.Text}\n" +
                $"Estado: {txt_estado.Text}\n" +
                $"Cidade: {txt_cidade.Text}\n",
                "Usuario",
                MessageBoxButtons.OK
            );
                this.Close();
                this.parent.Show();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botão Cancelar Cadastro
        private void btn_CancelarClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}