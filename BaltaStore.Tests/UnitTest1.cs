using BaltaStore.Domain.StoreContext.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaltaStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Customer(
                "André", 
                "Baltieri", 
                "12345678911", 
                "hello@balta.io", 
                "19999999999", 
                "Rua dos Developers, 1024");
        }
    }
}
