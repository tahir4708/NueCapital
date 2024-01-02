using NueCapital.WebApi.Application.Common.Interfaces;

namespace NueCapital.WebApi.Application.Common.Exporters;

public interface IExcelWriter : ITransientService
{
    Stream WriteToStream<T>(IList<T> data);
}