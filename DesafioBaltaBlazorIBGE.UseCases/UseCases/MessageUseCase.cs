using DesafioBaltaBlazorIBGE.Application.Interfaces;

namespace DesafioBaltaBlazorIBGE.Application.UseCases 
{
    public class MessageUseCase : IMessageService
    {
        public event Action<string, bool>? MessageSent;

        public void SendMessage(string message, bool success)
        {
            MessageSent?.Invoke(message, success);
        }
    }
}