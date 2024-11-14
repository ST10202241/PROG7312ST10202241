using System;

namespace PROG7312ST10202241.Models
{
    public class Event
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }

        public Event(string name, string category, DateTime date, string location)
        {
            if (date < DateTime.Now)
                throw new ArgumentException("Event date cannot be in the past.");

            Name = name;
            Category = category;
            Date = date;
            Location = location;
        }

        public override string ToString()
        {
            return $"{Name} - {Category} - {Date.ToShortDateString()} - {Location}";
        }
    }
}
