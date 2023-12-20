namespace DesafioBaltaBlazorIBGE.Application.InterfaceUseCases
{
    public interface IDeleteCityUseCase
    {
        Task<bool> Delete(int id);
    }
}
