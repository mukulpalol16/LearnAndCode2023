namespace EmailCarbonFootprint
{
    public class EmailEntityResponse
    {
        public string EmailId { get; set; }
        public double TotalInboxEmission { get; set; }
        public double TotalSentEmission { get; set; }
        public double TotalSpamEmission { get; set; }
        private double TotalEmission;

        public void Display()
        {
            Console.WriteLine("Email Entity");
            Console.WriteLine($"Email Id: {EmailId}");
            Console.WriteLine($"Inbox Emission: {TotalInboxEmission} KG");
            Console.WriteLine($"Sent Emission: {TotalSentEmission} KG");
            Console.WriteLine($"Spam Emission: {TotalSpamEmission} KG");
            Console.WriteLine($"Total Carbon Footprint: {TotalEmission} KG");
        }

        public void CalculateTotalEmission()
        {
            TotalEmission = TotalInboxEmission + TotalSentEmission + TotalSpamEmission;
        }
    }
}
