using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DebitOrdersApi.Features.Branchees.Commands;
using DebitOrdersApi.Features.Branchees.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DebitOrdersApi.Features.Branchees
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BranchesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost, Route("addBranch")]
        public async Task<ActionResult> AddBank(AddBranchees command)
        {
            var branch = await _mediator.Send(command);
            return Ok(branch);

        }

        [HttpGet, Route("getBranches")]
        public async Task<ActionResult> GetBanks()
        {
            var branches = await _mediator.Send(new GetBranchees());
            return Ok(branches);


        }
    }
}