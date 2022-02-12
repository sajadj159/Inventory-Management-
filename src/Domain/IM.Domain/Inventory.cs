using IM.Domain.Exceptions;

namespace IM.Domain
{
    public class Inventory
    {
        public int Id { get; private set; }
        public string Product { get; private set; }
        public double UnitPrice { get; private set; }
        public bool InStock { get; set; }

        public Inventory(string product, double unitPrice)
        {
            if (string.IsNullOrWhiteSpace(product))
                throw new ProductNullException();

            if (unitPrice <= 0)
                throw new InvalidUnitPriceException();

            Product = product;
            UnitPrice = unitPrice;
        }
    }
}