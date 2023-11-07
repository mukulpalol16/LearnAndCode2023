namespace EmailCarbonFootprint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                EmailEntity emailEntity = new EmailEntity();
                emailEntity.GetUserInput();

                ICarbonFootprintCalculator carbonFootprintCalculator = new EmailCarbonFootprintCalculator();
                EmailEntityResponse emailEntityResponse = carbonFootprintCalculator.CalculateCarbonFootprint(emailEntity);

                emailEntityResponse.DisplayTotalEmissionsDetail();
            }
            catch (FormatException)
            {
                Console.WriteLine("An Error Occured:");
                Console.WriteLine("Invalid input format. Please enter valid numeric values.");
            }
            catch (Exception exception)
            {
                Console.WriteLine("An Error Occured:");
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}