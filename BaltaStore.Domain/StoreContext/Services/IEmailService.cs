using BaltaStore.Domain.StoreContext.Entities;

namespace BaltaStore.Domain.StoreContext.Services
{
    public interface IEmailService
    {
        void Send(string to, string from, string subject, string body);
    }
}