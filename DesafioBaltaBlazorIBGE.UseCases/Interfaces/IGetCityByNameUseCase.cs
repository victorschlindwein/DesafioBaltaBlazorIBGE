using DesafioBaltaBlazorIBGE.Domain.Models;
using System.Threading.Tasks;

namespace DesafioBaltaBlazorIBGE.Application.Interfaces
{
    public interface IGetCityByNameUseCase
    {
        Task<List<Ibge>> GetCityIbge(string city, CancellationToken cancellationToken, int skip, int take);
        Task<int> GetTotalCityCountAsync(string city, CancellationToken cancellationToken);
    }
}
