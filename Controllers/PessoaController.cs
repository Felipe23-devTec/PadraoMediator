using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PadraoMadiatorAprendendo.Domain.Commands.Requests;

namespace PadraoMadiatorAprendendo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PessoaController : ControllerBase
{
    private readonly IMediator _mediator;
    public PessoaController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody]CreatePessoaRequest command)
    {
        var response = await _mediator.Send(command);
        return Ok(response);
    }
}
