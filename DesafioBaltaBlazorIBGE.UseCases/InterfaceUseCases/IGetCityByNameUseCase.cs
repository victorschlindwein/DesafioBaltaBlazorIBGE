using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.InterfaceUseCases
{
    public interface IGetCityByNameUseCase
    {
        Task<List<Ibge>> GetCityIbge(string city, CancellationToken cancellationToken, int skip, int take);
        Task<int> GetTotalCityCountAsync(string city, CancellationToken cancellationToken);
    }
}
