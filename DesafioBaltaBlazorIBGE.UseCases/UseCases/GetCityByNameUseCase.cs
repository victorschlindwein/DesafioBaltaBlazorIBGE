using DesafioBaltaBlazorIBGE.Application.InterfaceRepositories;
using DesafioBaltaBlazorIBGE.Application.InterfaceUseCases;
using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.UseCases
{
    public class GetCityByNameUseCase : IGetCityByNameUseCase
    {
        private readonly IGetCityIbgeRepository _ibgeRepository;

        public GetCityByNameUseCase(IGetCityIbgeRepository ibgeRepository)
            => _ibgeRepository = ibgeRepository;

        public async Task<List<Ibge>> GetCityIbge(string city, CancellationToken cancellationToken, int skip, int take)
            => await _ibgeRepository.GetCityIbge(city, cancellationToken, skip, take);

        public async Task<int> GetTotalCityCountAsync(string city, CancellationToken cancellationToken)
        {
            return await _ibgeRepository.GetTotalCityCountAsync(city, cancellationToken);
        }
    }
}
