using MediatR;
using PadraoMadiatorAprendendo.Domain.Commands.Responses;

namespace PadraoMadiatorAprendendo.Domain.Commands.Requests
{
    public class CreatePessoaRequest : IRequest<CreatePessoaResponse>
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
    }
}
