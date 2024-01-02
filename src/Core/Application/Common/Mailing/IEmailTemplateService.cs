using NueCapital.WebApi.Application.Common.Interfaces;

namespace NueCapital.WebApi.Application.Common.Mailing;

public interface IEmailTemplateService : ITransientService
{
    string GenerateEmailTemplate<T>(string templateName, T mailTemplateModel);
}