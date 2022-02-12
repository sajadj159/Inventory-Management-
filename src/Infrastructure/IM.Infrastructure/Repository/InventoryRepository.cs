using IM.Domain;
using IM.Domain.Repository;

namespace IM.Infrastructure.Repository
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly InventoryContext _inventoryContext;

        public InventoryRepository(InventoryContext inventoryContext)
        {
            _inventoryContext = inventoryContext;
        }

        public void Create(Inventory entity)
        {
            _inventoryContext.Inventories.Add(entity);
            Save();
        }

        public void Save()
        {
            _inventoryContext.SaveChanges();
        }
    }
}