namespace ElectronicDevices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDeviceFactory smartphoneFactory = new SmartphoneFactory();
            IDeviceFactory laptopFactory = new LaptopFactory();

            IDevice smartphone = smartphoneFactory.CreateDevice();
            IDevice laptop = laptopFactory.CreateDevice();

            smartphone.DisplayDetails();
            laptop.DisplayDetails();
        }
    }
}
