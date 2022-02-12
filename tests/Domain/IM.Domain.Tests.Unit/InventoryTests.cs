using System;
using FluentAssertions;
using IM.Domain.Exceptions;
using Xunit;

namespace IM.Domain.Tests.Unit
{
    public class InventoryTests
    {
        private readonly InventoryTestBuilder _inventoryTestBuilder;
        public InventoryTests()
        {
            _inventoryTestBuilder = new InventoryTestBuilder();
        }
        [Fact]
        public void Constructor_ShouldCreateANewInventory()
        {
            //Arrange
            const string product = "Mac";
            const double unitPrice = 1500;

            //Act
            var inventory = _inventoryTestBuilder.Build();

            //Assert
            inventory.Product.Should().Be(product);
            inventory.UnitPrice.Should().Be(unitPrice);
            inventory.InStock.Should().BeFalse();
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Constructor_ShouldReturnException_WhenProductIs(string nullOrWitheSpace)
        {

            //Act
            Action action = () => _inventoryTestBuilder.WithProduct(nullOrWitheSpace).Build();

            //Assert
            action.Should().ThrowExactly<ProductNullException>();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Constructor_ShouldReturnException_WhenUnitPriceIs(double zeroOrLess)
        {
            //Act
            Action action = () => _inventoryTestBuilder.WithUnitPrice(zeroOrLess).Build();

            //Assert
            action.Should().ThrowExactly<InvalidUnitPriceException>();

        }
    }
}
