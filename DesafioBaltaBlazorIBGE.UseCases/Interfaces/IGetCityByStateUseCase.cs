using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.Interfaces
{
    public interface IGetCityByStateUseCase
    {
        Task<List<Ibge>> GetStateIbge(string state, CancellationToken cancellationToken);
    }
}
