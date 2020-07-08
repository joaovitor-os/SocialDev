using Models;
using System.Collections.Generic;

namespace Controllers
{
    public class UsuarioController
    {
        // Inserindo usuário no banco de dados
        public static void CadastrarUsuario(
            string nomeUsuario,
            string emailUsuario,
            string descricaoUsuario,
            string nascimentoUsuario,
            string estadoUsuario,
            string cidadeUsuario
            )
        {
            new Usuario(
                nomeUsuario,
                emailUsuario,
                descricaoUsuario,
                nascimentoUsuario,
                estadoUsuario,
                cidadeUsuario);
        }

        // Acessando usuário no BD pelo ID
        public static Usuario GetUsuario(int idUsuario)
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
            string emailUsuario,
            string descricaoUsuario,
            string nascimentoUsuario,
            string estadoUsuario,
            string cidadeUsuario
            )
        {
            Usuario.AlterarUsuario(
            idUsuario,
            nomeUsuario,
            emailUsuario,
            descricaoUsuario,
            nascimentoUsuario,
            estadoUsuario,
            cidadeUsuario
            );
        }

        // Acessando o método de deletar
        public static void DeletarUsuario(int idUsuario)
        {
            Usuario.DeletarUsuario(idUsuario);
        }
    }
}