using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.Interfaces
{
    public interface IGetCitiesUseCase
    {
        Task<List<Ibge>> GetAllIbgeAsync(CancellationToken cancellationToken);
    }
}
