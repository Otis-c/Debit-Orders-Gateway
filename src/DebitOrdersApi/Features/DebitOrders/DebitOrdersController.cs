using DebitOrdersApi.Features.DebitOrders.Commands;
using DebitOrdersApi.Features.DebitOrders.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitOrdersApi.Features.DebitOrders
{
    [Route("api/[controller]")]
    [ApiController]
    public class DebitInstructionsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DebitInstructionsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost,Route("action")]
        public ActionResult<bool> CreateInstructions(SaveDebitOrder command)
        {
            _mediator.Send(command);
            return Ok(true);
        }

        [HttpGet, Route("GetInstructions")]
        public async Task<ActionResult<bool>> GetInstructions()
        {
            var instructions = await _mediator.Send(new GetDebitOrders());
            return Ok(instructions);
        }

        [HttpPost, Route("importTransactions")]
        public async Task<IActionResult> ImportTransactions()
        {
            if (Request.Form.Files.Count() > 0)
            {
                if (Request.Form.Files[0].Length > 0)
                {
                    var file = Request.Form.Files[0];
                    var fileBytes = await FiletoBytes(file);
                    var command = new ImportInstructions
                    {
                        FileBytes = fileBytes                        
                    };

                    await _mediator.Send(command);
                    return Ok();
                }
                else
                    return BadRequest("File does not conatin any data");
            }
            else
            {
                return BadRequest("No file was attached");
            }
        }
        private async Task<byte[]> FiletoBytes(IFormFile formFile)
        {
            using (var stream = new MemoryStream())
            {
                await formFile.CopyToAsync(stream);
                return stream.ToArray();

            }
        }
    }
}
