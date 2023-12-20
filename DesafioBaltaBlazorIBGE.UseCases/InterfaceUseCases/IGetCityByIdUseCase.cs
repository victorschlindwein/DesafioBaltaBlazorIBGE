using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.InterfaceUseCases
{
    public interface IGetCityByIdUseCase
    {
        Task<Ibge> GetByIdAsync(int id, CancellationToken cancellationToken);
    }
}
