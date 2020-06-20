using CachoSangueProjeto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CachoSangueProjeto.DAO
{
    public class ClinicaDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static void CadastrarClinica(Clinica Clinica)
        {
            ctx.Clinica.Add(Clinica);
            ctx.SaveChanges();
        }

        public static List<Clinica> RetornarClinicas()
        {
            return ctx.Clinica.ToList();
        }

        public static Clinica RetornarClinicaPorId(int id)
        {
            return ctx.Clinica.Find(id);
        }

        public static void RemoverClinica(int id)
        {
            Clinica u = RetornarClinicaPorId(id);
            ctx.Clinica.Remove(u);
            ctx.SaveChanges();
        }

        public static void AlterarClinica(Clinica clinica,int id)
        {
            Clinica c = RetornarClinicaPorId(id);

            c.NomeClinica = clinica.NomeClinica;
            c.Endereco = clinica.Endereco;
            c.Cep = clinica.Cep;

            ctx.Entry(c).State = EntityState.Modified;
            ctx.SaveChanges();
        }

    }
}