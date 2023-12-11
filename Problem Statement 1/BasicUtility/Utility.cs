namespace BasicUtility
{
    public class Utility
    {
        public int IntegerValue { get; set; }
        public double DoubleValue { get; set; }
        public string StringValue { get; set; }

        public void calculateSum(int input1, int input2)
        {
            int sum = input1 + input2;
            Console.WriteLine("Sum: " + sum);
        }

        public void convertToUpperCase(string inputString)
        {
            StringValue = inputString.ToUpper();
            Console.WriteLine("Uppercase String: " + StringValue);
        }
    }
}
