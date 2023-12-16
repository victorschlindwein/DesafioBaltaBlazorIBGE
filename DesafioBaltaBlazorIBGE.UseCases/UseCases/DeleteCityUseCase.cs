using DesafioBaltaBlazorIBGE.Application.Interfaces;

namespace DesafioBaltaBlazorIBGE.Application.UseCases
{
    public class DeleteCityUseCase : IDeleteCityUseCase
    {
        private readonly IIbgeRepository _ibgeRepository;

        public DeleteCityUseCase(IIbgeRepository ibgeRepository)
        {
            _ibgeRepository = ibgeRepository ?? throw new ArgumentNullException(nameof(ibgeRepository));
        }

        public async Task<bool> Delete(int id)
        {
            var isDeleted = await _ibgeRepository.Delete(id);
            return isDeleted;
        }
    }
}
