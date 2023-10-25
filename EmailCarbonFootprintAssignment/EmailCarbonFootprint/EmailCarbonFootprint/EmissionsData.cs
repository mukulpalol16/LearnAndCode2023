namespace EmailCarbonFootprint
{
    public class EmissionsData
    {
        public double SpamCarbonFootprintKg { get; set; }
        public double ShortEmailOnPhoneCarbonFootprintKg { get; set; }
        public double ShortEmailInLaptopCarbonFootprintKg { get; set; }
        public double LongEmailOnLaptopCarbonFootprintKg { get; set; }
        public double EmailBlastCarbonFootprintKg { get; set; }

        public void DisplayCarbonEmission()
        {
            Console.WriteLine($"Carbon footprint of spam emails: {SpamCarbonFootprintKg} kg");
            Console.WriteLine($"Carbon footprint of short emails sent on phone: {ShortEmailOnPhoneCarbonFootprintKg} kg");
            Console.WriteLine($"Carbon footprint of short emails sent on laptop: {ShortEmailInLaptopCarbonFootprintKg} kg");
            Console.WriteLine($"Carbon footprint of long emails sent on laptop: {LongEmailOnLaptopCarbonFootprintKg} kg");
            Console.WriteLine($"Carbon footprint of email blasts: {EmailBlastCarbonFootprintKg} kg");
        }

        public static double SpamEmission = 0.03;
        public static double ShortEmailOnPhoneEmission = 0.2;
        public static double ShortEmailOnLaptopEmission = 0.3;
        public static double LongEmailOnLaptopEmission = 17;
        public static double EmailBlastEmission = 26;
    }
}
