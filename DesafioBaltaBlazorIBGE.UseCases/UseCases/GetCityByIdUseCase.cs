using DesafioBaltaBlazorIBGE.Application.InterfaceRepositories;
using DesafioBaltaBlazorIBGE.Application.InterfaceUseCases;
using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Application.UseCases
{
    public class GetCityByIdUseCase : IGetCityByIdUseCase
    {
        private readonly IGetByIdAsyncRepository? _ibgeRepository;

        public GetCityByIdUseCase(IGetByIdAsyncRepository ibgeRepository)
            => _ibgeRepository = ibgeRepository;

        public async Task<Ibge> GetByIdAsync(int id, CancellationToken cancellationToken)
            => await _ibgeRepository.GetByIdAsync(id, cancellationToken);
    }
}
