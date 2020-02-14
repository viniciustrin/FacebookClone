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
    public class Deletar
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
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

                _context.Remove(atividade);
                var sucesso = await _context.SaveChangesAsync() > 0;
                if (sucesso) return Unit.Value;

                throw new Exception("Problemas para editar.");
            }
        }
    }
}
