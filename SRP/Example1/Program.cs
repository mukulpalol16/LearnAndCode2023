namespace RectangleAreaCalculator
{
    public class Program
    {
        static void Main()
        {
            Rectangle rectangle = new Rectangle(5.0, 3.0);
            
            double area = rectangle.CalculateArea();

            Printer printer = new Printer();
            printer.PrintArea(area);
        }
    }
}
