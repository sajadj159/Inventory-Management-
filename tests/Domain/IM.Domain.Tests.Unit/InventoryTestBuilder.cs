namespace IM.Domain.Tests.Unit
{
    public class InventoryTestBuilder
    {
        private string _product = "Mac";
        private double _unitPrice = 1500;

        public Inventory Build()
        {
            return new Inventory(_product, _unitPrice);
        }

        public InventoryTestBuilder WithProduct(string product)
        {
            _product = product;
            return this;
        }

        public InventoryTestBuilder WithUnitPrice(double unitPrice)
        {
            _unitPrice = unitPrice;
            return this;
        }
    }
}