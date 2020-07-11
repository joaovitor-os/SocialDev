using Models;
using System.Collections.Generic;

namespace Controllers
{
    public class UsuarioController
    {
        // Inserindo usuário no banco de dados
        public static void CadastrarUsuario(
            string nomeUsuario,
            string email,
            string senhaUsuario,
            string descricao,
            string github,
            string linkedin
            )
        {
            new Usuario(
                nomeUsuario,
                email,
                senhaUsuario,
                descricao,
                github,
                linkedin);
        }

        // Acessando usuário no BD pelo ID
        public static Models.Usuario GetUsuario(int idUsuario)
        {
            return Usuario.GetUsuario(idUsuario);
        }

        // Acessando todos usuários
        public static List<Usuario> GetUsuarios()
        {
            return Usuario.GetUsuarios();
        }

        // Acessando o método de alteração
        public static void AlterarUsuario(
            int idUsuario,
            string nomeUsuario,
            string email,
            string senhaUsuario,
            string descricao,
            string github,
            string linkedin
            )
        {
            Usuario.AlterarUsuario(
            idUsuario,
            nomeUsuario,
            email,
            senhaUsuario,
            descricao,
            github,
            linkedin
            );
        }

        // Acessando o método de deleção
        public static void DeletarUsuario(int idUsuario)
        {
            Usuario.DeletarUsuario(idUsuario);
        }

        public static bool ConfirmarSenhasIguais(string senha1, string senha2)
        {
            if (senha1 == senha2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CamposPreenchidosCadastroUsuario(
            string nomeCompleto,
            string usuario,
            string senha,
            string confirmarSenha,
            string descricao)
        {
            if ((nomeCompleto == string.Empty)
                || (usuario == string.Empty)
                || (senha == string.Empty)
                || (confirmarSenha == string.Empty)
                || (descricao == string.Empty))
            {
                return false;
            }
            return true;
        }
    }
}