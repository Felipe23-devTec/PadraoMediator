using MediatR;

namespace PadraoMadiatorAprendendo.Domain.Notifications;

public class LogEventHandler : INotificationHandler<PessoaCriadaNotification>, INotificationHandler<ErroNotification>
{
    public Task Handle(PessoaCriadaNotification notification, CancellationToken cancellationToken)
    {
        return Task.Run(() =>
        {
            Console.WriteLine($"CRIACAO: '{notification.Message} - {notification.Nome}'");
        });
    }

    public Task Handle(ErroNotification notification, CancellationToken cancellationToken)
    {
        return Task.Run(() =>
        {
            Console.WriteLine($"ERRO: '{notification.Excecao} \n {notification.PilhaErro}'");
        });
    }
}
