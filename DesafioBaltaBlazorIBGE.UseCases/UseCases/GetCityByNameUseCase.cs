using DesafioBaltaBlazorIBGE.Application.Interfaces;
using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.UseCases
{
    public class GetCityByNameUseCase : IGetCityByNameUseCase
    {
        private readonly IIbgeRepository _ibgeRepository;

        public GetCityByNameUseCase(IIbgeRepository ibgeRepository)
            => _ibgeRepository = ibgeRepository;

        public async Task<List<Ibge>> GetCityIbge(string city, CancellationToken cancellationToken, int skip, int take)
            => await _ibgeRepository.GetCityIbge(city, cancellationToken, skip, take);

        public async Task<int> GetTotalCityCountAsync(string city, CancellationToken cancellationToken)
        {
            return await _ibgeRepository.GetTotalCityCountAsync(city, cancellationToken);
        }
    }
}
