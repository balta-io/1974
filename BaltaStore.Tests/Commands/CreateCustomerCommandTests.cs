using BaltaStore.Domain.StoreContext.CustomerCommands.Inputs;
using BaltaStore.Domain.StoreContext.Entities;
using BaltaStore.Domain.StoreContext.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaltaStore.Tests
{
    [TestClass]
    public class CreateCustomerCommandTests
    {
        [TestMethod]
        public void ShouldValidateWhenCommandIsValid()
        {
            var command = new CreateCustomerCommand();
            command.FirstName = "André";
            command.LastName = "Baltieri";
            command.Document = "28659170377";
            command.Email = "andrebaltieri@gmail.com";
            command.Phone = "11999999997";

            Assert.AreEqual(true, command.Valid());
        }
    }
}
