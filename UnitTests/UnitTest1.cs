using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace UnitTests
{
    public class Tests
    {
        private async Task<WebTestApplication.Models.CrudExampleContext> GetDatabaseContext()
        {
            var options = new DbContextOptionsBuilder<WebTestApplication.Models.CrudExampleContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
        }
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}
