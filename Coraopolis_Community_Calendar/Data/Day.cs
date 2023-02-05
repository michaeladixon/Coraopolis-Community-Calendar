namespace Coraopolis_Community_Calendar.Data
{
    public class Day
    {
        public Guid Id { get; set; }

        public string Note { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Message { get; set; }

        public DateTime EventDate { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        


    }
}
