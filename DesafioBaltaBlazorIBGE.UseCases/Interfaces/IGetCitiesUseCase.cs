using System.ComponentModel;
using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.Interfaces
{
    public interface IGetCitiesUseCase
    {
        Task<List<Ibge>> GetAllIbgeAsync(CancellationToken cancellationToken, int skip, int take);
        Task<int> GetTotalItemCountAsync(CancellationToken cancellationToken);
    }
}
