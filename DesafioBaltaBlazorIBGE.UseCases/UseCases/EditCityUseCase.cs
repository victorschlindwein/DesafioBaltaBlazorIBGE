using DesafioBaltaBlazorIBGE.Application.Interfaces;
using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.UseCases
{
    public class EditCityUseCase
    {
        private readonly IIbgeRepository _ibgeRepository;

        public EditCityUseCase(IIbgeRepository ibgeRepository)
        {
            _ibgeRepository = ibgeRepository ?? throw new ArgumentNullException(nameof(ibgeRepository));
        }

        public async Task<Ibge> UpdateIbge(int id, Ibge ibge)
            => await _ibgeRepository.UpdateIbge(id, ibge);
    }
}
