using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.InterfaceRepositories
{
    public interface IGetAllIbgeAsyncRepository
    {
        Task<List<Ibge>> GetAllIbgeAsync(CancellationToken cancellationToken, int skip, int take);
        Task<int> GetTotalItemCountAsync(CancellationToken cancellationToken);
    }
}
