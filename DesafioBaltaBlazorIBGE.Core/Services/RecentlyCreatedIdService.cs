namespace DesafioBaltaBlazorIBGE.Domain.Services;

public class RecentlyCreatedIdService
{
    private int _recentlyCreatedId;

    public int RecentlyCreatedId
    {
        get => _recentlyCreatedId;
        set => _recentlyCreatedId = value;
    }
}
