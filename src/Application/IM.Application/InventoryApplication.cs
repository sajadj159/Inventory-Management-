using IM.Application.Contract;
using IM.Domain;
using IM.Domain.Repository;

namespace IM.Application
{
    public class InventoryApplication:IInventoryApplication
    {
        private readonly IInventoryRepository _inventoryRepository;

        public InventoryApplication(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        public bool Define(DefineInventory command)
        {
            var inventory = new Inventory(command.Product,command.UnitPrice);
            _inventoryRepository.Create(inventory);
            return true;
        }
    }
}