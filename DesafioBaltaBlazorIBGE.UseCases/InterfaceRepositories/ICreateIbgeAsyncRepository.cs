using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.InterfaceRepositories
{
    public interface ICreateIbgeAsyncRepository
    {
        Task<Ibge> CreateIbgeAsync(Ibge ibge);
    }
}
