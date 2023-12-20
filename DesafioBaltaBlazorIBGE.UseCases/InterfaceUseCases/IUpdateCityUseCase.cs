using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.InterfaceUseCases
{
    public interface IUpdateCityUseCase
    {
        Task<Ibge> UpdateIbge(int id, Ibge ibge);
    }
}
