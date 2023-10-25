namespace EmailCarbonFootprint
{
    public class CarbonFootprintCalculator
    {
        public EmailModel CalculateCarbonFootprint(EmailModel email)
        {
            EmissionsData emissionsData = new EmissionsData();
            emissionsData.SpamCarbonFootprintKg = (email.SpamQuantity * EmissionsData.SpamEmission) / 1000;
            emissionsData.ShortEmailOnPhoneCarbonFootprintKg = (email.ShortEmailOnPhoneQuantity * EmissionsData.ShortEmailOnPhoneEmission) / 1000;
            emissionsData.ShortEmailInLaptopCarbonFootprintKg = (email.ShortEmailOnLaptopQuantity * EmissionsData.ShortEmailOnLaptopEmission) / 1000;
            emissionsData.LongEmailOnLaptopCarbonFootprintKg = (email.LongEmailOnLaptopQuantity * EmissionsData.LongEmailOnLaptopEmission) / 1000;
            emissionsData.EmailBlastCarbonFootprintKg = (email.EmailBlastQuantity * EmissionsData.EmailBlastEmission) / 1000;

            email.CarbonFootprintKg = emissionsData.SpamCarbonFootprintKg + emissionsData.ShortEmailInLaptopCarbonFootprintKg + emissionsData.ShortEmailOnPhoneCarbonFootprintKg + emissionsData.LongEmailOnLaptopCarbonFootprintKg + emissionsData.EmailBlastCarbonFootprintKg;
            email.EmissionsData = emissionsData;
            return email;
        }
    }

}
