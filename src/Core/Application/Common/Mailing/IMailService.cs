using NueCapital.WebApi.Application.Common.Interfaces;

namespace NueCapital.WebApi.Application.Common.Mailing;

public interface IMailService : ITransientService
{
    Task SendAsync(MailRequest request, CancellationToken ct);
}