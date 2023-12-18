namespace BasicUtility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility utilityObject = new Utility();
            utilityObject.Operand = 10;
            utilityObject.DecimalValue = 20.5;
            utilityObject.ConvertedText = "hello";

            utilityObject.CalculateSum(utilityObject.Operand, 5);
            utilityObject.ConvertToUpperCase("world");
        }
    }
}
