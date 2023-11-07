namespace EmailCarbonFootprint
{
    public class EmailCarbonFootprintCalculator : ICarbonFootprintCalculator
    {
        private const double InboxEmissionPerEmail = 4.0;
        private const double SentEmissionPerEmail = 0.2;
        private const double SpamEmissionPerEmail = 0.3;

        public EmailEntityResponse CalculateCarbonFootprint(EmailEntity emailEntity)
        {
            double inboxEmission = (emailEntity.InboxCount * InboxEmissionPerEmail) / 1000;
            double sentEmission = (emailEntity.SentCount * SentEmissionPerEmail) / 1000;
            double spamEmission = (emailEntity.SpamCount * SpamEmissionPerEmail) / 1000;
            
            EmailEntityResponse response = new EmailEntityResponse();
            response.EmailId = emailEntity.EmailId;
            response.TotalInboxEmission = Math.Round(inboxEmission, 6);
            response.TotalSentEmission = Math.Round(sentEmission, 6);
            response.TotalSpamEmission = Math.Round(spamEmission, 6);
            response.CalculateTotalEmission();
            return response;
        }
    }
}
