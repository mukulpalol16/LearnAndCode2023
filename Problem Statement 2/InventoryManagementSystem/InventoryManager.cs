namespace InventoryManagementSystem
{
    public class InventoryManager
    {
        private List<Product> inventory;

        public InventoryManager()
        {
            this.inventory = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            inventory.Add(product);
        }

        public List<Product> GetInventory()
        {
            return inventory;
        }
    }
}
