using DesafioBaltaBlazorIBGE.Application.InterfaceRepositories;
using DesafioBaltaBlazorIBGE.Application.InterfaceUseCases;
using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.UseCases
{
    public class GetCitiesUseCase : IGetCitiesUseCase
    {
        private readonly IGetAllIbgeAsyncRepository _ibgeRepository;

        public GetCitiesUseCase(IGetAllIbgeAsyncRepository ibgeRepository)
            => _ibgeRepository = ibgeRepository;

        public async Task<List<Ibge>> GetAllIbgeAsync(CancellationToken cancellationToken, int skip, int take)
            => await _ibgeRepository.GetAllIbgeAsync(cancellationToken, skip, take);

        public async Task<int> GetTotalItemCountAsync(CancellationToken cancellationToken)
        {
            return await _ibgeRepository.GetTotalItemCountAsync(cancellationToken);
        }
    }
}
