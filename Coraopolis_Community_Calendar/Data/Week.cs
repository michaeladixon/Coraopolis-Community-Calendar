namespace Coraopolis_Community_Calendar.Data
{
    public class Week
    {
        public ICollection<Day> Days { get; set; } = new List<Day>();

    }
}
