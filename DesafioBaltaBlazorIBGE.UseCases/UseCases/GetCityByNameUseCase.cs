using DesafioBaltaBlazorIBGE.Application.Interfaces;
using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.UseCases
{
    public class GetCityByNameUseCase : IGetCityByNameUseCase
    {
        private readonly IIbgeRepository _ibgeRepository;

        public GetCityByNameUseCase(IIbgeRepository ibgeRepository)
        {
            _ibgeRepository = ibgeRepository ?? throw new ArgumentNullException(nameof(ibgeRepository));
        }

        public async Task<List<Ibge>> GetCityIbge(string city, CancellationToken cancellationToken)
            => await _ibgeRepository.GetCityIbge(city, cancellationToken);
    }
}
