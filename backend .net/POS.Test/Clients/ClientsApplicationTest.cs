using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using POS.Application.Interfaces;
using POS.Utilities.Static;


namespace POS.Test.Clients
{
    [TestClass]
    public class ClientsApplicationTest
    {
        private static WebApplicationFactory<Program>? _factory = null;
        private static IServiceScopeFactory? _scopeFactory = null;

        [ClassInitialize]
        public static void Initialize(TestContext _testContext)
        {
            _factory = new CustomWebApplicationFactory();
            _scopeFactory = _factory.Services.GetService<IServiceScopeFactory>();
        }

        [TestMethod]
        public async Task RegisterClient_WhenSendingNullValuesOrEmpty_ValidationErrros()
        {
            using var scope = _scopeFactory?.CreateScope();
            var context = scope?.ServiceProvider.GetService<IClientApplication>();

            //Arrange
            var Nombre = "";
            var NumeroWhatsapp = "";
            var expected = ReplyMessage.MESSAGE_VALIDATE;
            //Act
            var result = await context.RegisterClient(new Application.Dtos.Request.ClientRequestDto()
            {
                Nombre = Nombre,
                NumeroWhatsapp = NumeroWhatsapp
            });
            var current = result.Message;
            //Assert
            Assert.AreEqual(expected, current);
        }
    }
}
