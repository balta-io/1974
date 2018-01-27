using BaltaStore.Domain.StoreContext.Services;

namespace BaltaStore.Infra.StoreContext.Services
{
    public class EmailService : IEmailService
    {
        public void Send(string to, string from, string subject, string body)
        {
            // TODO: Implementar
        }
    }
}