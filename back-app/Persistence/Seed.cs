using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Persistence
{
    public static class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Atividades.Any())
            {
                var atividades = new List<Atividade>
                {
                    new Atividade
                    {
                        Titulo = "Atividade Passada 1",
                        Data = DateTime.Now.AddMonths(-2),
                        Descricao = "Atividade 2 meses atrás",
                        Categoria = "bebidas",
                        Cidade = "Londres",
                        Local = "Pub",
                    },
                    new Atividade
                    {
                        Titulo = "Atividade Passada 2",
                        Data = DateTime.Now.AddMonths(-1),
                        Descricao = "Atividade 1 mês atrás",
                        Categoria = "culture",
                        Cidade = "Paris",
                        Local = "Louvre",
                    },
                    new Atividade
                    {
                        Titulo = "Atividade Futura 1",
                        Data = DateTime.Now.AddMonths(1),
                        Descricao = "Atividade 1 month in future",
                        Categoria = "culture",
                        Cidade = "Londres",
                        Local = "Natural History Museum",
                    },
                    new Atividade
                    {
                        Titulo = "Atividade Futura 2",
                        Data = DateTime.Now.AddMonths(2),
                        Descricao = "Atividade 2 months in future",
                        Categoria = "music",
                        Cidade = "Londres",
                        Local = "O2 Arena",
                    },
                    new Atividade
                    {
                        Titulo = "Atividade Futura 3",
                        Data = DateTime.Now.AddMonths(3),
                        Descricao = "Atividade 3 months in future",
                        Categoria = "bebidas",
                        Cidade = "Londres",
                        Local = "Another pub",
                    },
                    new Atividade
                    {
                        Titulo = "Atividade Futura 4",
                        Data = DateTime.Now.AddMonths(4),
                        Descricao = "Atividade 4 months in future",
                        Categoria = "bebidas",
                        Cidade = "Londres",
                        Local = "Yet another pub",
                    },
                    new Atividade
                    {
                        Titulo = "Atividade Futura 5",
                        Data = DateTime.Now.AddMonths(5),
                        Descricao = "Atividade 5 months in future",
                        Categoria = "bebidas",
                        Cidade = "Londres",
                        Local = "Just another pub",
                    },
                    new Atividade
                    {
                        Titulo = "Atividade Futura 6",
                        Data = DateTime.Now.AddMonths(6),
                        Descricao = "Atividade 6 months in future",
                        Categoria = "music",
                        Cidade = "Londres",
                        Local = "Roundhouse Camden",
                    },
                    new Atividade
                    {
                        Titulo = "Atividade Futura 7",
                        Data = DateTime.Now.AddMonths(7),
                        Descricao = "Atividade 2 months ago",
                        Categoria = "travel",
                        Cidade = "Londres",
                        Local = "Somewhere on the Thames",
                    },
                    new Atividade
                    {
                        Titulo = "Atividade Futura 8",
                        Data = DateTime.Now.AddMonths(8),
                        Descricao = "Atividade 8 months in future",
                        Categoria = "film",
                        Cidade = "Londres",
                        Local = "Cinema",
                    }
                };
                context.Atividades.AddRange(atividades);
                context.SaveChanges();
            }
        }
    }
}