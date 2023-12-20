using DesafioBaltaBlazorIBGE.Domain.Models;
using DesafioBaltaBlazorIBGE.Application.InterfaceRepositories;
using DesafioBaltaBlazorIBGE.Application.InterfaceUseCases;

namespace DesafioBaltaBlazorIBGE.Application.UseCases
{
    public class CreateCityUseCase : ICreateCityUseCase
    {
        private readonly ICreateIbgeAsyncRepository _ibgeRepository;

        public CreateCityUseCase(ICreateIbgeAsyncRepository ibgeRepository)
            => _ibgeRepository = ibgeRepository;

        public async Task<Ibge> CreateIbgeAsync(Ibge ibge)
            => await _ibgeRepository.CreateIbgeAsync(ibge);
    }
}
