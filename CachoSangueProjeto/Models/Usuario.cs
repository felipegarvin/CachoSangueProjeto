using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CachoSangueProjeto.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        public string Nome { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public string Cpf { get; set; }

        public string Email { get; set; }

        public string Fone { get; set; }

        public int PadraoAcesso { get; set; }

        enum PadraoAcessoUsuario
        {
            admin = 1,
            padrao = 0
        }

        //public Usuario () {
        //    IdUsuario = 1;
        //    Nome = "GarfinhoViviArthurGhisi";
        //    Login = "cachorro";
        //    Senha = "auau";
        //    Cpf = "123";
        //    Email = "cachorrao@auau.com";
        //    Fone = "157";
        //    PadraoAcesso = 1;
        //}
    }
}