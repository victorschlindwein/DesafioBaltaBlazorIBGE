using DesafioBaltaBlazorIBGE.Application.Interfaces;
using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.UseCases
{
    public class GetCityByIdUseCase : IGetCityByIdUseCase
    {
        private readonly IIbgeRepository? _ibgeRepository;

        public GetCityByIdUseCase(IIbgeRepository ibgeRepository)
            => _ibgeRepository = ibgeRepository;

        public async Task<Ibge> GetByIdAsync(int id, CancellationToken cancellationToken)
            => await _ibgeRepository.GetByIdAsync(id, cancellationToken);
    }
}
