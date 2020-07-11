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
        public string Email { get; set; }
        [Required]
        public string SenhaUsuario { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public string Github { get; set; }
        [Required]
        public string Linkedin { get; set; }
        

        public Usuario(string nomeUsuario, string email, string senhaUsuario, string descricao, string github, string linkedin)
        {
            NomeUsuario = nomeUsuario;
            Email = email;
            SenhaUsuario = senhaUsuario;
            Descricao = descricao;
            Github = github;
            Linkedin = linkedin;

            Context db = new Context();
            db.Usuarios.Add(this);
            db.SaveChanges();
        }
        
        public static Usuario GetUsuario(int idUsuario)
        {
            var db = new Context();
            return (from usuario in db.Usuarios
                    where usuario.IdUsuario == idUsuario
                    select usuario).First();
        }
        public static List<Usuario> GetUsuarios()
        {
            var db = new Context();
            return db.Usuarios.ToList();
        }
            public static void AlterarUsuario(
            int IdUsuario,
            string nomeUsuario,
            string email,
            string senhaUsuario,
            string descricao,
            string github,
            string linkedin
        )
        {
            Context db = new Context();
            try
            {
                Usuario usuario = db.Usuarios.First(usuario => usuario.IdUsuario == IdUsuario);
                usuario.NomeUsuario = nomeUsuario;
                usuario.Email = email;
                usuario.SenhaUsuario = senhaUsuario;
                usuario.Descricao = descricao;
                usuario.Github = github;
                usuario.Linkedin = linkedin;
                db.SaveChanges(); // Cria a transação do BD
            }
            catch
            {
                throw new ArgumentException();
            }
        }
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
        public static Usuario ValidaUsuario(string login, string senha)
        {
            try
            {
            Context db = new Context();
            IEnumerable<Usuario> usuario = from Usuario in db.Usuarios
                where Usuario.Email == login && Usuario.SenhaUsuario == senha
                select Usuario;
            return usuario.ToArray().First();
            }
            catch
            {
                throw new Exception("Usuário e/ou Senha Inválido!");
            }
        }
    }
}