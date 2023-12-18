namespace DesafioBaltaBlazorIBGE.Domain.Services
{
    public class MessagesService
    {
        public event Action<string, bool>? MessageSent;

        public void SendMessage(string message, bool success)
        {
            MessageSent?.Invoke(message, success);
        }
    }
}
