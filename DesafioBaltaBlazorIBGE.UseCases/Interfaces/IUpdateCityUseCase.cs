using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.Interfaces
{
    public interface IUpdateCityUseCase
    {
        Task<Ibge> UpdateIbge(int id, Ibge ibge);
    }
}
