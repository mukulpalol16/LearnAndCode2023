namespace EmailCarbonFootprint
{
    public class CarbonFootprintCalculator
    {
        public EmailModel CalculateCarbonFootprint(EmailModel email)
        {
            EmissionsData emissionsData = new EmissionsData();
            emissionsData.SpamCarbonFootprintKg = (email.SpamQuantity * EmissionsDataConstants.SpamEmission) / 1000;
            emissionsData.ShortEmailOnPhoneCarbonFootprintKg = (email.ShortEmailOnPhoneQuantity * EmissionsDataConstants.ShortEmailOnPhoneEmission) / 1000;
            emissionsData.ShortEmailInLaptopCarbonFootprintKg = (email.ShortEmailOnLaptopQuantity * EmissionsDataConstants.ShortEmailOnLaptopEmission) / 1000;
            emissionsData.LongEmailOnLaptopCarbonFootprintKg = (email.LongEmailOnLaptopQuantity * EmissionsDataConstants.LongEmailOnLaptopEmission) / 1000;
            emissionsData.EmailBlastCarbonFootprintKg = (email.EmailBlastQuantity * EmissionsDataConstants.EmailBlastEmission) / 1000;

            email.CarbonFootprintKg = emissionsData.SpamCarbonFootprintKg + emissionsData.ShortEmailInLaptopCarbonFootprintKg + emissionsData.ShortEmailOnPhoneCarbonFootprintKg + emissionsData.LongEmailOnLaptopCarbonFootprintKg + emissionsData.EmailBlastCarbonFootprintKg;
            email.EmissionsData = emissionsData;
            return email;
        }
    }
}
