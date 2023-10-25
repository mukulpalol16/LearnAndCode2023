namespace EmailCarbonFootprint
{
    public class EmailModel : EmailTypeQuantity
    {
        public string EmailId { get; set; }
        public double CarbonFootprintKg { get; set; }
        public EmissionsData EmissionsData { get; set; }

        public void DisplayEmailCarbonFootprint()
        {
            Console.WriteLine("Total Carbon Footprint");
            Console.WriteLine($"Email Id: {EmailId}");
            EmissionsData.DisplayCarbonEmission();
            Console.WriteLine($"Carbon Footprint: {CarbonFootprintKg} kg");
        }
    }

}
