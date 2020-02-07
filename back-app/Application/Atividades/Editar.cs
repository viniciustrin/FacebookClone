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
    public class Editar
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
            public string Titulo { get; set; }
            public string Descricao { get; set; }
            public DateTime? Data { get; set; }
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
                var atividade = await _context.Atividades.FindAsync(request.Id);
                if (atividade == null)
                {
                    throw new Exception("Atividade não existe");
                }

                atividade.Titulo = request.Titulo ?? atividade.Titulo;
                atividade.Categoria = request.Categoria ?? atividade.Categoria;
                atividade.Descricao = request.Descricao ?? atividade.Descricao;
                atividade.Data = request.Data ?? atividade.Data;
                atividade.Cidade = request.Cidade ?? atividade.Cidade;
                atividade.Local = request.Local ?? atividade.Local;

                var sucesso = await _context.SaveChangesAsync() > 0;
                if (sucesso) return Unit.Value;

                throw new Exception("Problemas para editar.");
            }
        }
    }
}
