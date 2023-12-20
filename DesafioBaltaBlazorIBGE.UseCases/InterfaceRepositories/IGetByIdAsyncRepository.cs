using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.InterfaceRepositories
{
    public interface IGetByIdAsyncRepository
    {
        Task<Ibge> GetByIdAsync(int id, CancellationToken cancellationToken);
    }
}
