using MediatR;
using PadraoMadiatorAprendendo.Domain.Commands.Requests;
using PadraoMadiatorAprendendo.Domain.Commands.Responses;
using PadraoMadiatorAprendendo.Domain.Entities;
using PadraoMadiatorAprendendo.Repository;

namespace PadraoMadiatorAprendendo.Domain.Commands.Handles;

public class CreatePessoaHandle : IRequestHandler<CreatePessoaRequest, CreatePessoaResponse>
{
    private readonly IRepository<Pessoa> _repository;
    private readonly IMediator _mediator;
    public CreatePessoaHandle(IRepository<Pessoa> repository, IMediator mediator)
    {
        _repository = repository;
        _mediator = mediator;
    }

    public async Task<CreatePessoaResponse> Handle(CreatePessoaRequest request, CancellationToken cancellationToken)
    {
        var pessoa = new Pessoa();
        pessoa.Nome = request.Nome;
        pessoa.Idade = request.Idade;
        var response = new CreatePessoaResponse();
        await _repository.Add(pessoa);
        response.Message = "Pessoa criado com sucesso!";
        return response;
    }
}
