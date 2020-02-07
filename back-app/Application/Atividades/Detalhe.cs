using Domain;
using MediatR;
using Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Atividades
{
    public class Detalhe
    {
        public class Query : IRequest<Atividade>
        {
            public Guid Id { get; set; }
        }
        public class Handler : IRequestHandler<Query, Atividade>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<Atividade> Handle(Query request, CancellationToken cancellationToken)
            {
                var atividade = await _context.Atividades.FindAsync(request.Id);
                return atividade;
            }
        }
    }
}
