namespace EmailCarbonFootprint
{
    public class EmailEntity
    {
        public string EmailId { get; set; }
        public int InboxCount { get; set; }
        public int SentCount { get; set; }
        public int SpamCount { get; set; }

        public void GetDetails()
        {
            Console.Write("Enter the email address: ");
            EmailId = Console.ReadLine();

            if(EmailId == String.Empty)
            {
                throw new Exception("Email adress can not be empty");
            }

            Console.Write("Enter the number of inbox emails: ");
            InboxCount = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of sent emails: ");
            SentCount = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of spam emails: ");
            SpamCount = int.Parse(Console.ReadLine());
        }
    }
}
