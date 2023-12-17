namespace DesafioBaltaBlazorIBGE.Application.Interfaces
{
    public interface IDeleteCityUseCase
    {
        Task<bool> Delete(int id);
    }
}
