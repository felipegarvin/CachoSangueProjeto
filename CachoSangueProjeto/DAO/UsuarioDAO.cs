using CachoSangueProjeto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CachoSangueProjeto.DAO
{
    public class UsuarioDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static void CadastrarUsuario(Usuario usuario)
        {
            ctx.Usuario.Add(usuario);
            ctx.SaveChanges();
        }

        public static List<Usuario> RetornarUsuarios()
        {
            return ctx.Usuario.ToList();
        }

        public static Usuario RetornarUsuarioPorId(int id)
        {
            return ctx.Usuario.Find(id);
        }

        public static void RemoverUsuario(int id)
        {
            Usuario u = RetornarUsuarioPorId(id);
            ctx.Usuario.Remove(u);
            ctx.SaveChanges();
        }

        public static void AlterarUsuario(Usuario usuario, int id)
        {
            Usuario u = RetornarUsuarioPorId(id);

            u.Nome = usuario.Nome;
            u.Login = usuario.Login;
            u.Senha = usuario.Senha;
            u.Cpf = usuario.Cpf;
            u.Email = usuario.Email;
            u.Fone = usuario.Fone;
            u.PadraoAcesso = usuario.PadraoAcesso;

            ctx.Entry(u).State = EntityState.Modified;
            ctx.SaveChanges();
        }

    }
}