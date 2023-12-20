using DesafioBaltaBlazorIBGE.Application.InterfaceRepositories;
using DesafioBaltaBlazorIBGE.Application.InterfaceUseCases;
using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.UseCases
{
    public class GetCityByStateUseCase : IGetCityByStateUseCase
    {
        private readonly IGetStateIbgeRepository _ibgeRepository;

        public GetCityByStateUseCase(IGetStateIbgeRepository ibgeRepository)
            => _ibgeRepository = ibgeRepository;

        public async Task<List<Ibge>> GetStateIbge(string state, CancellationToken cancellationToken, int skip, int take)
            => await _ibgeRepository.GetStateIbge(state, cancellationToken, skip, take);

        public async Task<int> GetTotalStateCountAsync(string state, CancellationToken cancellationToken)
        {
            return await _ibgeRepository.GetTotalStateCountAsync(state, cancellationToken);
        }
    }
}
