namespace DesafioBaltaBlazorIBGE.Application.Interfaces;

public interface IMessageService
{
    void SendMessage(string message, bool success);
}