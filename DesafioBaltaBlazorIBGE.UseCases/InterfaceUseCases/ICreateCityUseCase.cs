using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.InterfaceUseCases
{
    public interface ICreateCityUseCase
    {
        Task<Ibge> CreateIbgeAsync(Ibge ibge);
    }
}
