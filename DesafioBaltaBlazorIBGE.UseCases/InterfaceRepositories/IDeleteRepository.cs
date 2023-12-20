namespace DesafioBaltaBlazorIBGE.Application.InterfaceRepositories
{
    public interface IDeleteRepository
    {
        Task<bool> Delete(int id);
    }
}
