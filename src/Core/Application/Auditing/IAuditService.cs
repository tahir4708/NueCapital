using NueCapital.WebApi.Application.Common.Interfaces;

namespace NueCapital.WebApi.Application.Auditing;

public interface IAuditService : ITransientService
{
    Task<List<AuditDto>> GetUserTrailsAsync(DefaultIdType userId);
}