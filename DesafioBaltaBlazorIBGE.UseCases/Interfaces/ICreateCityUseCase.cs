using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.Interfaces
{
    public interface ICreateCityUseCase
    {
        Task<Ibge> CreateIbgeAsync(Ibge ibge);
    }
}
