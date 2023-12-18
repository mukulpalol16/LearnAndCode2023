namespace InventoryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InventoryManager inventoryManager = new InventoryManager();

            while (true)
            {
                Console.WriteLine("\nInventory Management System");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Display Inventory");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter product name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter product price: ");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter product quantity: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());

                        Product product = new Product(name, price, quantity);
                        inventoryManager.AddProduct(product);

                        Console.WriteLine("Product added successfully!");
                        break;

                    case 2:
                        Console.WriteLine("\nCurrent Inventory:");
                        List<Product> productsInInventory = inventoryManager.GetInventory();
                        foreach (Product currentProduct in productsInInventory)
                        {
                            Console.WriteLine($"Name: {currentProduct.Name}, Price: ${currentProduct.Price}, Quantity: {currentProduct.Quantity}");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Exiting program. Goodbye!");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }
    }
}
