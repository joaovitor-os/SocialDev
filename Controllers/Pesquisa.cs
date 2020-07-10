using Models;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    public class Pesquisa
    {
        public static void PesquisarUsuario(){
            System.Console.WriteLine("Menu de busca de usuário");
            System.Console.WriteLine("Informe o nome do usuário desejado: ");
            string NomeUsuario = (Console.ReadLine());
            IEnumerable<Models.Usuario> usuarioQuery = 
                from NomeUsuario in Db.socialdev()
                where NomeUsuario.Usuario == NomeUsuario
                select NomeUsuario;
            foreach(Models.Usuario usuario in usuarioQuery){
                Console.WriteLine(Usuario.nomeUsuario);
                Console.WriteLine(Usuario.emailUsuario);
                Console.WriteLine(Usuario.descricaoUsuario);
                Console.WriteLine(Usuario.cidadeUsuario);
            }
        }
    }
}