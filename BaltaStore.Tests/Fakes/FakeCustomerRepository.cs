using BaltaStore.Domain.StoreContext.Entities;
using BaltaStore.Domain.StoreContext.Repositories;

namespace BaltaStore.Tests
{
    public class FakeCustomerRepository : ICustomerRepository
    {
        public bool CheckDocument(string document)
        {
            return false;
        }

        public bool CheckEmail(string email)
        {
            return false;
        }

        public void Save(Customer customer)
        {
            
        }
    }
}
