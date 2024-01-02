using NueCapital.WebApi.Application.Common.Interfaces;
using NueCapital.WebApi.Shared.Events;

namespace NueCapital.WebApi.Application.Common.Events;

public interface IEventPublisher : ITransientService
{
    Task PublishAsync(IEvent @event);
}