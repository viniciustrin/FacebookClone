using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Atividades
{
    public class List
    {
        public class Query : IRequest<List<Atividade>> { }
        public class Handler : IRequestHandler<Query, List<Atividade>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Atividade>> Handle(Query request, CancellationToken cancellationToken)
            {
                var atividades = await _context.Atividades.ToListAsync();

                return atividades;
            }
        }
    }
}
