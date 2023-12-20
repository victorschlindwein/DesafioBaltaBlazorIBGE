using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.InterfaceRepositories
{
    public interface IUpdateIbgeRepository
    {
        Task<Ibge> UpdateIbge(int id, Ibge ibge);
    }
}
