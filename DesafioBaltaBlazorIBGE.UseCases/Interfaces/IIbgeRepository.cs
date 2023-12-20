using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.Interfaces
{
    public interface IIbgeRepository
    {
        Task<Ibge> CreateIbgeAsync(Ibge ibge);
        Task<List<Ibge>> GetAllIbgeAsync(CancellationToken cancellationToken, int skip, int take);
        Task<int> GetTotalItemCountAsync(CancellationToken cancellationToken);
        Task<Ibge> GetByIdAsync(int id, CancellationToken cancellationToken);
        Task<List<Ibge>> GetCityIbge(string city, CancellationToken cancellationToken, int skip, int take);
        Task<int> GetTotalCityCountAsync(string state, CancellationToken cancellationToken);
        Task<List<Ibge>> GetStateIbge(string state, CancellationToken cancellationToken, int skip, int take);
        Task<int> GetTotalStateCountAsync(string state, CancellationToken cancellationToken);
        Task<Ibge> UpdateIbge(int id, Ibge ibge);
        Task<bool> Delete(int id);
    }
}
