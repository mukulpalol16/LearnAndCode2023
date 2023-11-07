namespace EmailCarbonFootprint
{
    public interface ICarbonFootprintCalculator
    {
        EmailEntityResponse CalculateCarbonFootprint(EmailEntity emailEntity);
    }
}
