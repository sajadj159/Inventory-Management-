namespace IM.Domain.Repository
{
    public interface IInventoryRepository
    {
        void Create(Inventory entity);
        void Save();
    }
}