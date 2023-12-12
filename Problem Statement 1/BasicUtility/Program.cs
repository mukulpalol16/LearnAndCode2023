namespace BasicUtility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility utilityObject = new Utility();
            utilityObject.IntegerValue = 10;
            utilityObject.DoubleValue = 20.5;
            utilityObject.StringValue = "hello";

            utilityObject.calculateSum(utilityObject.IntegerValue, 5);
            utilityObject.convertToUpperCase("world");
        }
    }
}
