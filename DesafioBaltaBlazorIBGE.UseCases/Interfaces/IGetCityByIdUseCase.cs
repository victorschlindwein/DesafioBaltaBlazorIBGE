using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.Interfaces
{
    public interface IGetCityByIdUseCase
    {
        Task<Ibge> GetByIdAsync(int id, CancellationToken cancellationToken);
    }
}
