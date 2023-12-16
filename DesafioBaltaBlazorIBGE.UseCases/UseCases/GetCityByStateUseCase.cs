using DesafioBaltaBlazorIBGE.Application.Interfaces;
using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.UseCases
{
    public class GetCityByStateUseCase : IGetCityByStateUseCase
    {
        private readonly IIbgeRepository _ibgeRepository;

        public GetCityByStateUseCase(IIbgeRepository ibgeRepository)
        {
            _ibgeRepository = ibgeRepository ?? throw new ArgumentNullException(nameof(ibgeRepository));
        }

        public async Task<List<Ibge>> GetStateIbge(string state, CancellationToken cancellationToken)
            => await _ibgeRepository.GetStateIbge(state, cancellationToken);
    }
}
