using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

