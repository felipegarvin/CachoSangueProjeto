using CachoSangueProjeto.Controllers;
using CachoSangueProjeto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CachoSangueProjeto.DAO
{
    public class Facade
    {

       public static int RetornarPadAcess() { 

            Usuario usuario = new Usuario();

            usuario.IdUsuario = 1;
            usuario.Nome = "GarfinhoViviArthurGhisi";
            usuario.Login = "cachorro";
            usuario.Senha = "auau";
            usuario.Cpf = "123";
            usuario.Email = "cachorrao@auau.com";
            usuario.Fone = "157";
            usuario.PadraoAcesso = 1;


            return (usuario.PadraoAcesso);


        }

        

    }
}