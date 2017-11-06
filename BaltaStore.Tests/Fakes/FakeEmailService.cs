using BaltaStore.Domain.StoreContext.Entities;
using BaltaStore.Domain.StoreContext.Services;

namespace BaltaStore.Tests
{
    public class FakeEmailService : IEmailService
    {
        public void Send(string to, string from, string subject, string body)
        {
            
        }
    }
}
