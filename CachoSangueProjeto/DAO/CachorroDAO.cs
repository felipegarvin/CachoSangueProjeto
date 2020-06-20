﻿using CachoSangueProjeto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CachoSangueProjeto.DAO
{
    public class CachorroDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static void CadastrarCachorro(Cachorro Cachorro)
        {
            ctx.Cachorro.Add(Cachorro);
            ctx.SaveChanges();
        }

        public static List<Cachorro> RetornarCachorros()
        {
            return ctx.Cachorro.ToList();
        }

        public static Cachorro RetornarCachorroPorId(int id)
        {
            return ctx.Cachorro.Find(id);
        }

        public static void RemoverCachorro(int id)
        {
            Cachorro u = RetornarCachorroPorId(id);
            ctx.Cachorro.Remove(u);
            ctx.SaveChanges();
        }

        public static void AlterarCachorro(Cachorro cachorro, int id)
        {
            Cachorro c = RetornarCachorroPorId(id);

            c.NomeCachorro = cachorro.NomeCachorro;
            c.Idade = cachorro.Idade;
            c.Raca = cachorro.Raca;
            c.Pesoa = cachorro.Pesoa;
            c.Tamanho = cachorro.Tamanho;
            c.Doenca = cachorro.Doenca;
            c.Sexo = cachorro.Sexo;
            c.Cor = cachorro.Cor;
            c.TipoSanguineo = cachorro.TipoSanguineo;

            ctx.Entry(c).State = EntityState.Modified;
            ctx.SaveChanges();
        }

    }
}