using MediatR;

namespace PadraoMadiatorAprendendo.Domain.Notifications;

public class PessoaCriadaNotification : INotification
{
    public string Message { get; set; }
    public string Nome { get; set; }
}
