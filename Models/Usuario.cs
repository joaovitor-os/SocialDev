using System;
using System.Linq;
using DbRespositorie;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Usuario
    {
        [Key] // Data Annotations - Chave principal
        public int IdUsuario { get; set; }
        [Required] // Propriedades requeridas na classe
        public string NomeUsuario { get; set; }
        [Required]
        public string LoginUsuario { get; set; }
        [Required]
        public string SenhaUsuario { get; set; }
        [Required]
        public string EmailUsuario { get; set; }
        [Required]
        public string DescricaoUsuario { get; set; }
        [Required]
        public string CidadeUsuario { get; set; }

        // Construtor do objeto Usuario
        public Usuario(string nomeUsuario, string loginUsuario, string senhaUsuario, string emailUsuario, string descricaoUsuario, string cidadeUsuario)
        {
            NomeUsuario = nomeUsuario;
            LoginUsuario = loginUsuario;
            SenhaUsuario = senhaUsuario;
            EmailUsuario = emailUsuario;
            DescricaoUsuario = descricaoUsuario;
            CidadeUsuario = cidadeUsuario;

            var db = new Context();
            db.Usuarios.Add(this);
            db.SaveChanges();
        }

        // 2º Constructor do obejto UsuarioModels
        // Usado pelo Entity Framework NÃO REMOVA!!!
        public Usuario()
        {

        }

        // Método para pegar o usuário pelo ID        
        public static Usuario GetUsuario(int idUsuario)
        {
            var db = new Context();
            return (from usuario in db.Usuarios
                    where usuario.IdUsuario == idUsuario
                    select usuario).First();
        }

        // Método para pegar a lista de usuários       
        public static List<Usuario> GetUsuarios()
        {
            var db = new Context();
            return db.Usuarios.ToList();
        }

        // Método para alterar os dados do usuário       
        public static void AlterarUsuario(
            int IdUsuario,
            string nomeUsuario,
            string loginUsuario,
            string senhaUsuario,
            string emailUsuario,
            string descricaoUsuario,
            string cidadeUsuario
        )
        {
            Context db = new Context();
            try
            {
                Usuario usuario = db.Usuarios.First(usuario => usuario.IdUsuario == IdUsuario);
                usuario.NomeUsuario = nomeUsuario;
                usuario.LoginUsuario = loginUsuario;
                usuario.SenhaUsuario = senhaUsuario;
                usuario.EmailUsuario = emailUsuario;
                usuario.DescricaoUsuario = descricaoUsuario;
                usuario.CidadeUsuario = cidadeUsuario;
                db.SaveChanges(); // Cria a transação do BD
            }
            catch
            {
                throw new ArgumentException();
            }
        }

        // Método de deleção do usuário        
        public static void DeletarUsuario(int idUsuario)
        {
            Context db = new Context();
            try
            {
                Usuario usuario = db.Usuarios.First(usuario => usuario.IdUsuario == idUsuario);
                db.Remove(usuario);
                db.SaveChanges();
            }
            catch
            {
                throw new ArgumentException();
            }
        }
    }
}