using IM.Application.Contract;
using IM.Presentation.Controllers;
using NSubstitute;
using Xunit;

namespace IM.Presentation.Tests.Unit
{
    public class InventoryControllerTests
    {
        private readonly IInventoryApplication _inventoryApplication;
        private readonly InventoryController _inventoryController;

        public InventoryControllerTests()
        {
            _inventoryApplication = Substitute.For<IInventoryApplication>();
            _inventoryController = new InventoryController(_inventoryApplication);
        }

        [Fact]
        public void Create_ShouldCallDefineOnApplication()
        {
            //Arrange
            var command = new DefineInventory { Product = "Iphone", UnitPrice = 2500 };

            //Act
            _inventoryController.Define(command);

            //Assert
            _inventoryApplication.Received().Define(command);
        }
    }
}
