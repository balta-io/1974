using BaltaStore.Domain.StoreContext.CustomerCommands.Inputs;
using BaltaStore.Domain.StoreContext.Entities;
using BaltaStore.Domain.StoreContext.Enums;
using BaltaStore.Domain.StoreContext.ValueObjects;
using BaltaStore.Infra.DataContexts;
using BaltaStore.Infra.StoreContext.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaltaStore.Tests
{
    [TestClass]
    public class DapperTests
    {
        [TestMethod]
        public void DeleteMe()
        {
            var ctx = new BaltaDataContext();
            var repo = new CustomerRepository(ctx);

            Assert.AreEqual(repo.CheckDocument("99999999999"), true);
        }

        [TestMethod]
        public void DeleteMeToo()
        {
            var ctx = new BaltaDataContext();
            var repo = new CustomerRepository(ctx);

            // Recupera os produtos do banco
            var name = new Name("André", "Baltieri");
            var document = new Document("46718115533");
            var email = new Email("hello@balta.io");
            var customer = new Customer(name, document, email, "551999876542");
            var address = new Address("Rua", "1", "N/A", "Meu Bairro", "Piracicaba", "SP", "BR", "13400000", EAddressType.Billing);
            var address2 = new Address("Rua2", "2", "N/A", "Meu Bairro", "Piracicaba", "SP", "BR", "13400000", EAddressType.Shipping);
            customer.AddAddress(address);
            customer.AddAddress(address2);

            repo.Save(customer);
        }
    }
}
