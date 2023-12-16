using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.Interfaces
{
    public interface IGetCityByNameUseCase
    {
        Task<List<Ibge>> GetCityIbge(string city, CancellationToken cancellationToken);
    }
}
