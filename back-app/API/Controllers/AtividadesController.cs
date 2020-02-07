using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Atividades;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtividadesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AtividadesController(IMediator mediator)
        {
            _mediator = mediator;
        }
       
        [HttpGet]
        public async Task<ActionResult<List<Atividade>>> Listar()
        {
            return await _mediator.Send(new Lista.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Atividade>> Detalhe(Guid id)
        {
            return await _mediator.Send(new Detalhe.Query {Id = id });
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Inserir(Inserir.Command cmd)
        {
            return await _mediator.Send(cmd);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Unit>> Editar(Guid id, Editar.Command cmd)
        {
            cmd.Id = id;
            return await _mediator.Send(cmd);
        }
    }
}