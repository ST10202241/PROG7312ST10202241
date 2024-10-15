/*using PROG7312ST10202241.Forms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

namespace PROG7312ST10202241
{
    public partial class LocalEventsAndAccouncementsForm : Form
    {
        private SortedDictionary<DateTime, List<Event>> eventsByDate;
        private HashSet<string> uniqueCategories;
        private Dictionary<string, List<Event>> userSearchHistory;
        private ResourceManager resourceManager;

        public LocalEventsAndAccouncementsForm()
        {
            InitializeComponent();
            resourceManager = new ResourceManager("PROG7312ST10202241.Properties.Strings", typeof(LocalEventsAndAccouncementsForm).Assembly);
            ApplyLocalization();
            InitializeDataStructures();
            LoadSampleData(); // Load sample data for testing
            DisplayEvents(); // Display events on form load
        }

        private void ApplyLocalization()
        {
            this.Text = resourceManager.GetString("LocalEventsAndAnnouncementsTitle");
            backToMainMenuBtn.Text = resourceManager.GetString("BackToMainMenuBtn");
            searchBtn.Text = resourceManager.GetString("SearchBtn"); // Ensure you have this string in your resources
        }

        // Initialize data structures
        private void InitializeDataStructures()
        {
            eventsByDate = new SortedDictionary<DateTime, List<Event>>();
            uniqueCategories = new HashSet<string>();
            userSearchHistory = new Dictionary<string, List<Event>>();
        }

        // Load sample events (You can replace this with actual data retrieval)
        private void LoadSampleData()
        {
            AddEvent(new Event("Community Cleanup", "Community Service", DateTime.Now.AddDays(5), "Community Park"));
            AddEvent(new Event("Local Market Day", "Market", DateTime.Now.AddDays(7), "Town Square"));
            AddEvent(new Event("Annual Music Festival", "Festival", DateTime.Now.AddDays(10), "City Center"));
            AddEvent(new Event("Tech Fair", "Technology", DateTime.Now.AddDays(15), "Convention Center"));
        }

        // Method to add events to the data structures
        private void AddEvent(Event eventItem)
        {
            if (!eventsByDate.ContainsKey(eventItem.Date))
            {
                eventsByDate[eventItem.Date] = new List<Event>();
            }
            eventsByDate[eventItem.Date].Add(eventItem);
            uniqueCategories.Add(eventItem.Category);
        }

        // Display events in a ListBox (assume listBoxEvents is a ListBox control on your form)
        private void DisplayEvents()
        {
            listBoxEvents.Items.Clear(); // Clear previous items
            foreach (var dateEntry in eventsByDate)
            {
                foreach (var eventItem in dateEntry.Value)
                {
                    listBoxEvents.Items.Add(eventItem); // Display each event
                }
            }
            UpdateCategoryComboBox(); // Update category dropdown
        }

        // Update the category ComboBox (assume comboBoxCategories is a ComboBox control on your form)
        private void UpdateCategoryComboBox()
        {
            comboBoxCategories.Items.Clear(); // Clear existing items
            comboBoxCategories.Items.AddRange(uniqueCategories.ToArray()); // Add unique categories
        }

        // Event handler for search button
        private void searchBtn_Click(object sender, EventArgs args)
        {
            string selectedCategory = comboBoxCategories.SelectedItem?.ToString();
            DateTime selectedDate = dateTimePicker.Value.Date; // Assume dateTimePicker is a DateTimePicker on your form
            var filteredEvents = eventsByDate.Values.SelectMany(x => x)
                .Where(e => (selectedCategory == null || e.Category == selectedCategory) &&
                            (e.Date.Date == selectedDate));
            listBoxEvents.Items.Clear(); // Clear the existing event list
            foreach (var eventItem in filteredEvents)
            {
                listBoxEvents.Items.Add(eventItem); // Display filtered events
            }
            RecordUserSearch(selectedCategory, selectedDate); // Record search
            ShowRecommendations(); // Show recommendations
        }

        // Record user search for recommendations
        private void RecordUserSearch(string category, DateTime date)
        {
            string key = $"{category}_{date.ToShortDateString()}"; // Create a key for search history
            if (!userSearchHistory.ContainsKey(key))
            {
                userSearchHistory[key] = new List<Event>();
            }
            userSearchHistory[key].AddRange(eventsByDate.Values.SelectMany(x => x)
                .Where(e => e.Category == category)); // Save events matching the search
        }

        // Show recommendations based on user search history
        private void ShowRecommendations()
        {
            listBoxRecommendations.Items.Clear(); // Clear previous recommendations
            foreach (var entry in userSearchHistory)
            {
                foreach (var eventItem in entry.Value)
                {
                    if (!listBoxRecommendations.Items.Contains(eventItem))
                    {
                        listBoxRecommendations.Items.Add(eventItem); // Add recommendations
                    }
                }
            }
        }

        // Close application on form close
        private void LocalEventsAndAccouncementsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Navigate back to main menu
        private void backToMainMenuBtn_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Hide();
        }
    }

    // Event class to represent an event
    public class Event
    {
        public string Title { get; }
        public string Category { get; }
        public DateTime Date { get; }
        public string Location { get; }

        public Event(string title, string category, DateTime date, string location)
        {
            Title = title;
            Category = category;
            Date = date;
            Location = location;
        }

        public override string ToString()
        {
            return $"{Title} - {Category} - {Date.ToShortDateString()} - {Location}"; // Customize the display format
        }
    }
}
*/
using PROG7312ST10202241.Forms;
using PROG7312ST10202241.PROG7312ST10202241.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

namespace PROG7312ST10202241
{
    public partial class LocalEventsAndAccouncementsForm : Form
    {
        private SortedDictionary<DateTime, List<Event>> eventsByDate;
        private HashSet<string> uniqueCategories;
        private Dictionary<string, List<Event>> userSearchHistory;
        private ResourceManager resourceManager;

        public LocalEventsAndAccouncementsForm()
        {
            InitializeComponent();
            resourceManager = new ResourceManager("PROG7312ST10202241.Properties.Strings", typeof(LocalEventsAndAccouncementsForm).Assembly);
            ApplyLocalization();
            InitializeDataStructures();
            LoadSampleData(); // Load sample data for testing
            DisplayEvents(); // Display events on form load
        }

        private void ApplyLocalization()
        {
            this.Text = resourceManager.GetString("LocalEventsAndAnnouncementsTitle");
            backToMainMenuBtn.Text = resourceManager.GetString("BackToMainMenuBtn");
            searchBtn.Text = resourceManager.GetString("SearchBtn"); // Ensure you have this string in your resources
        }

        // Initialize data structures
        private void InitializeDataStructures()
        {
            eventsByDate = new SortedDictionary<DateTime, List<Event>>();
            uniqueCategories = new HashSet<string>();
            userSearchHistory = new Dictionary<string, List<Event>>();
        }

        // Load sample events (You can replace this with actual data retrieval)
        private void LoadSampleData()
        {
            AddEvent(new Event("Community Cleanup", "Community Service", DateTime.Now.AddDays(5), "Community Park"));
            AddEvent(new Event("Local Market Day", "Market", DateTime.Now.AddDays(7), "Town Square"));
            AddEvent(new Event("Annual Music Festival", "Festival", DateTime.Now.AddDays(10), "City Center"));
            AddEvent(new Event("Tech Fair", "Technology", DateTime.Now.AddDays(15), "Convention Center"));
        }

        // Method to add events to the data structures
        private void AddEvent(Event eventItem)
        {
            if (!eventsByDate.ContainsKey(eventItem.Date))
            {
                eventsByDate[eventItem.Date] = new List<Event>();
            }
            eventsByDate[eventItem.Date].Add(eventItem);
            uniqueCategories.Add(eventItem.Category);
        }

        // Display events in a ListBox (assume listBoxEvents is a ListBox control on your form)
        private void DisplayEvents()
        {
            listBoxEvents.Items.Clear(); // Clear previous items
            foreach (var dateEntry in eventsByDate)
            {
                foreach (var eventItem in dateEntry.Value)
                {
                    listBoxEvents.Items.Add(eventItem); // Display each event
                }
            }
            UpdateCategoryComboBox(); // Update category dropdown
        }

        // Update the category ComboBox (assume comboBoxCategories is a ComboBox control on your form)
        private void UpdateCategoryComboBox()
        {
            comboBoxCategories.Items.Clear(); // Clear existing items
            comboBoxCategories.Items.AddRange(uniqueCategories.ToArray()); // Add unique categories
        }

        // Event handler for search button
        private void searchBtn_Click(object sender, EventArgs args)
        {
            string selectedCategory = comboBoxCategories.SelectedItem?.ToString();
            DateTime selectedDate = dateTimePicker.Value.Date; // Assume dateTimePicker is a DateTimePicker on your form
            var filteredEvents = eventsByDate.Values.SelectMany(x => x)
                .Where(e => (selectedCategory == null || e.Category == selectedCategory) &&
                            (e.Date.Date == selectedDate));
            listBoxEvents.Items.Clear(); // Clear the existing event list
            foreach (var eventItem in filteredEvents)
            {
                listBoxEvents.Items.Add(eventItem); // Display filtered events
            }
            RecordUserSearch(selectedCategory, selectedDate); // Record search
            ShowRecommendations(); // Show recommendations
        }

        // Record user search for recommendations
        private void RecordUserSearch(string category, DateTime date)
        {
            string key = $"{category}_{date.ToShortDateString()}"; // Create a key for search history
            if (!userSearchHistory.ContainsKey(key))
            {
                userSearchHistory[key] = new List<Event>();
            }
            userSearchHistory[key].AddRange(eventsByDate.Values.SelectMany(x => x)
                .Where(e => e.Category == category)); // Save events matching the search
        }

        // Show recommendations based on user search history
        private void ShowRecommendations()
        {
            listBoxRecommendations.Items.Clear(); // Clear previous recommendations
            foreach (var entry in userSearchHistory)
            {
                foreach (var eventItem in entry.Value)
                {
                    if (!listBoxRecommendations.Items.Contains(eventItem))
                    {
                        listBoxRecommendations.Items.Add(eventItem); // Add recommendations
                    }
                }
            }
        }

        // Close application on form close
        private void LocalEventsAndAccouncementsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Navigate back to main menu
        private void backToMainMenuBtn_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Hide();
        }
    }

    // Event class to represent an event


namespace PROG7312ST10202241.Models
    {
        public class Event
        {
            public int Id { get; set; } // Add Id for database primary key
            public string Title { get; set; }
            public string Category { get; set; }
            public DateTime Date { get; set; }
            public string Location { get; set; }

            public Event(string title, string category, DateTime date, string location)
            {
                Title = title;
                Category = category;
                Date = date;
                Location = location;
            }

            // Parameterless constructor for data retrieval
            public Event() { }

            public override string ToString()
            {
                return $"{Title} - {Category} - {Date.ToShortDateString()} - {Location}";
            }
        }
    }
}