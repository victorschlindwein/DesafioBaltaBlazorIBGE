using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.InterfaceUseCases
{
    public interface IGetCitiesUseCase
    {
        Task<List<Ibge>> GetAllIbgeAsync(CancellationToken cancellationToken, int skip, int take);
        Task<int> GetTotalItemCountAsync(CancellationToken cancellationToken);
    }
}
