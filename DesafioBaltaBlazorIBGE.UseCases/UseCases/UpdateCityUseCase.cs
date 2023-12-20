using DesafioBaltaBlazorIBGE.Application.InterfaceRepositories;
using DesafioBaltaBlazorIBGE.Application.InterfaceUseCases;
using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.UseCases
{
    public class UpdateCityUseCase : IUpdateCityUseCase
    {
        private readonly IUpdateIbgeRepository _ibgeRepository;

        public UpdateCityUseCase(IUpdateIbgeRepository ibgeRepository)
            => _ibgeRepository = ibgeRepository;

        public async Task<Ibge> UpdateIbge(int id, Ibge ibge)
            => await _ibgeRepository.UpdateIbge(id, ibge);
    }
}
