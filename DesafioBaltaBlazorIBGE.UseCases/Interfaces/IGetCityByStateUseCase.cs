using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.Interfaces
{
    public interface IGetCityByStateUseCase
    {
        Task<List<Ibge>> GetStateIbge(string state, CancellationToken cancellationToken, int skip, int take);
        Task<int> GetTotalStateCountAsync(string state, CancellationToken cancellationToken);
    }
}
