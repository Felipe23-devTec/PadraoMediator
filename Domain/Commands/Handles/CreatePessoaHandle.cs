using MediatR;
using PadraoMadiatorAprendendo.Domain.Commands.Requests;
using PadraoMadiatorAprendendo.Domain.Commands.Responses;
using PadraoMadiatorAprendendo.Domain.Entities;
using PadraoMadiatorAprendendo.Domain.Notifications;
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
        var response = new CreatePessoaResponse();
        try
        {
            var pessoa = new Pessoa();
            pessoa.Nome = request.Nome;
            pessoa.Idade = request.Idade;
            
            await _repository.Add(pessoa);
            response.Message = "Pessoa criado com sucesso!";
            await _mediator.Publish(new PessoaCriadaNotification { Message = "Criado com sucesso!", Nome = request.Nome });
            return response;
        }
        catch (Exception ex)
        {
            await _mediator.Publish(new PessoaCriadaNotification { Message = "Erro!", Nome = request.Nome });
            await _mediator.Publish(new ErroNotification { Excecao = ex.Message, PilhaErro = ex.StackTrace });
            return response;
        }
        
    }
}
