namespace BasicUtility
{
    public class Utility
    {
        public int Operand { get; set; }
        public double DecimalValue { get; set; }
        public string ConvertedText { get; set; }

        public void CalculateSum(int input1, int input2)
        {
            int sum = input1 + input2;
            Console.WriteLine("Sum: " + sum);
        }

        public void ConvertToUpperCase(string inputText)
        {
            ConvertedText = inputText.ToUpper();
            Console.WriteLine("Uppercase String: " + ConvertedText);
        }
    }
}
