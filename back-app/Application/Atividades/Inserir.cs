using MediatR;
using Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Domain;

namespace Application.Atividades
{
    public class Inserir
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
            public string Titulo { get; set; }
            public string Descricao { get; set; }
            public DateTime Data { get; set; }
            public string Categoria { get; set; }
            public string Cidade { get; set; }
            public string Local { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var atividade = new Atividade
                {
                    Id = request.Id,
                    Descricao = request.Descricao,
                    Categoria = request.Categoria,
                    Data = request.Data,
                    Cidade = request.Cidade,
                    Local = request.Local
                };

                _context.Atividades.Add(atividade);
                var sucesso = await _context.SaveChangesAsync() > 0;
                if (sucesso) return Unit.Value;

                throw new Exception("Problemas para inserir.");
            }
        }
    }
}
