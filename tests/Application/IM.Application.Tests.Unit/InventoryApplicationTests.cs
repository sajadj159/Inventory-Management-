using FluentAssertions;
using IM.Application.Contract;
using IM.Domain.Repository;
using NSubstitute;
using Xunit;

namespace IM.Application.Tests.Unit
{
    public class InventoryApplicationTests
    {
        private readonly InventoryApplication _inventoryApplication;
        private readonly IInventoryRepository _inventoryRepository;
        public InventoryApplicationTests()
        {
            _inventoryRepository = Substitute.For<IInventoryRepository>();
            _inventoryApplication = new InventoryApplication(_inventoryRepository);

        }
        [Fact]
        public void Define_ShouldReturnTrue_WhenInventoryIsDefined()
        {
            //Arrange
            var command = new DefineInventory { Product = "Mac", UnitPrice = 6500 };

            //Act
            var result = _inventoryApplication.Define(command);

            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Define_ShouldDefineNewInventory()
        {
            //Arrange
            var command = new DefineInventory{Product = "Iphone",UnitPrice = 1500};

            //Act
            _inventoryApplication.Define(command);

            //Assert
            _inventoryRepository.ReceivedWithAnyArgs().Create(default);
        }
    }
}
