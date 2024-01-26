using MediatR;

namespace PadraoMadiatorAprendendo.Domain.Notifications;

public class ErroNotification : INotification
{
    public string Excecao { get; set; }
    public string PilhaErro { get; set; }
}
