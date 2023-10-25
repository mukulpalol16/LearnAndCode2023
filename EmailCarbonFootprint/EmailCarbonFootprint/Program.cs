namespace EmailCarbonFootprint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var email = new EmailModel
                {
                    EmailId = "abc@xyz.com",
                    SpamQuantity = 10,
                    ShortEmailOnLaptopQuantity = 10,
                    ShortEmailOnPhoneQuantity = 10,
                    LongEmailOnLaptopQuantity = 10,
                    EmailBlastQuantity = 10
                };

                var calculator = new CarbonFootprintCalculator();
                var result = calculator.CalculateCarbonFootprint(email);
                result.DisplayEmailCarbonFootprint();

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}