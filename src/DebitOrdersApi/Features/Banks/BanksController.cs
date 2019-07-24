using DebitOrdersApi.Features.Banks.Commands;
using DebitOrdersApi.Features.Banks.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DebitOrdersApi.Features.Banks
{
    [Route("api/[controller]")]
    [ApiController]
    public class BanksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BanksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost, Route("addBank")]
        public async Task<ActionResult> AddBank(AddBank command)
        {
            var bank = await _mediator.Send(command);
            return Ok(bank);

        }

        [HttpGet, Route("getBanks")]
        public async Task<ActionResult> GetBanks()
        {
            var banks = await _mediator.Send(new GetBanks());
            return Ok(banks);


        }
    }
}
