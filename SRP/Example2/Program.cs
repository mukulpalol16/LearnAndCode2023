namespace RectangleAreaApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5.0, 3.0);
            double area = rectangle.CalculateArea();

            FileWriter.WriteToFile("area.txt", $"Area: {area}");

            Console.WriteLine($"Calculated Area: {area}");
        }
    }
}
