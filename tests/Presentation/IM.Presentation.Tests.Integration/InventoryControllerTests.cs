using FluentAssertions;
using IM.Application;
using IM.Application.Contract;
using Microsoft.AspNetCore.Mvc.Testing;
using RESTFulSense.Clients;
using Xunit;

namespace IM.Presentation.Tests.Integration
{
    public class InventoryControllerTests
    {
        private readonly RESTFulApiFactoryClient _client;
        public InventoryControllerTests()
        {
            var factory = new WebApplicationFactory<Startup>();
            var httpClient = factory.CreateClient();
            _client = new RESTFulApiFactoryClient(httpClient);
        }
        [Fact]
        public async void Define_ShouldDefineANewInventory()
        {
            //Arrange
            var command = new DefineInventory{Product = "Iphone",UnitPrice = 2500};

            //Act
            var result = await _client.PostContentAsync<DefineInventory ,bool>("/api/inventory",command);


            //Assert
            result.Should().BeTrue();
        }
    }
}