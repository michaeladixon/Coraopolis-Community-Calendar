namespace Coraopolis_Community_Calendar.Data
{
    public class Month
    {
        public ICollection<Week> Weeks { get; set; } = new List<Week>();
    }
}
