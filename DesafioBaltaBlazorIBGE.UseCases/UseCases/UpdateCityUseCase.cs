using DesafioBaltaBlazorIBGE.Application.Interfaces;
using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.UseCases
{
    public class UpdateCityUseCase : IUpdateCityUseCase
    {
        private readonly IIbgeRepository _ibgeRepository;

        public UpdateCityUseCase(IIbgeRepository ibgeRepository)
            => _ibgeRepository = ibgeRepository;

        public async Task<Ibge> UpdateIbge(int id, Ibge ibge)
            => await _ibgeRepository.UpdateIbge(id, ibge);
    }
}
