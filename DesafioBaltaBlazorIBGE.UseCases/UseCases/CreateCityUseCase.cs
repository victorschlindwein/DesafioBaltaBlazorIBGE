using DesafioBaltaBlazorIBGE.Domain.Models;
using DesafioBaltaBlazorIBGE.Application.Interfaces;

namespace DesafioBaltaBlazorIBGE.Application.UseCases
{
    public class CreateCityUseCase : ICreateCityUseCase
    {
        private readonly IIbgeRepository _ibgeRepository;

        public CreateCityUseCase(IIbgeRepository ibgeRepository)
        {
            _ibgeRepository = ibgeRepository ?? throw new ArgumentNullException(nameof(ibgeRepository));
        }

        public async Task<Ibge> CreateIbgeAsync(Ibge ibge)
            => await _ibgeRepository.CreateIbgeAsync(ibge);
    }
}
