namespace EmailCarbonFootprint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                EmailEntity emailEntity = new EmailEntity();
                emailEntity.GetDetails();

                ICarbonFootprintCalculator carbonFootprintCalculator = new EmailCarbonFootprintCalculator();
                EmailEntityResponse emailEntityResponse = carbonFootprintCalculator.CalculateCarbonFootprint(emailEntity);

                emailEntityResponse.Display();

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some Error Occured!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}