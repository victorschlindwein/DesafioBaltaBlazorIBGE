using DesafioBaltaBlazorIBGE.Application.Interfaces;
using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.UseCases
{
    public class GetCitiesUseCase : IGetCitiesUseCase
    {
        private readonly IIbgeRepository _ibgeRepository;

        public GetCitiesUseCase(IIbgeRepository ibgeRepository)
        {
            _ibgeRepository = ibgeRepository ?? throw new ArgumentNullException(nameof(ibgeRepository));
        }

        public async Task<List<Ibge>> GetAllIbgeAsync(CancellationToken cancellationToken)
            => await _ibgeRepository.GetAllIbgeAsync(cancellationToken);
    }
}
