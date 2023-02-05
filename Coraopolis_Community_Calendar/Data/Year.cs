namespace Coraopolis_Community_Calendar.Data
{
    public class Year
    {
        public ICollection<Month> Months { get; set; } = new List<Month>();
    }
}