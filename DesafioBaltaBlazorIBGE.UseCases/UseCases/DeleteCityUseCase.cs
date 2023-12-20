using DesafioBaltaBlazorIBGE.Application.InterfaceRepositories;
using DesafioBaltaBlazorIBGE.Application.InterfaceUseCases;

namespace DesafioBaltaBlazorIBGE.Application.UseCases
{
    public class DeleteCityUseCase : IDeleteCityUseCase
    {
        private readonly IDeleteRepository _ibgeRepository;

        public DeleteCityUseCase(IDeleteRepository ibgeRepository)
            => _ibgeRepository = ibgeRepository;

        public async Task<bool> Delete(int id)
        {
            var isDeleted = await _ibgeRepository.Delete(id);
            return isDeleted;
        }
    }
}
