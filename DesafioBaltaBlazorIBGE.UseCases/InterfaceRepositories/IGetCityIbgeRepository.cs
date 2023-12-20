using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.InterfaceRepositories
{
    public interface IGetCityIbgeRepository
    {
        Task<List<Ibge>> GetCityIbge(string city, CancellationToken cancellationToken, int skip, int take);
        Task<int> GetTotalCityCountAsync(string state, CancellationToken cancellationToken);
    }
}
