/*using System.Collections.Generic;
using PROG7312ST10202241.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using PROG7312ST10202241.Forms;

namespace PROG7312ST10202241
{
    public partial class LocalEventsAndAccouncementsForm : Form
    {
        private SortedDictionary<DateTime, Queue<Event>> eventsByDate;
        private HashSet<string> uniqueCategories;
        private Stack<string> userSearchHistory;
        private Dictionary<string, int> searchFrequency; 
        private PriorityQueue<Event, DateTime> eventPriorityQueue;
        private ResourceManager resourceManager;


        public LocalEventsAndAccouncementsForm()
        {
            InitializeComponent();
            resourceManager = new ResourceManager("PROG7312ST10202241.Properties.Strings", typeof(LocalEventsAndAccouncementsForm).Assembly);
            ApplyLocalization();
            InitializeDataStructures();
            LoadSampleData(); // Load sample data instead of database data
            DisplayEvents(); // Display events on form load
        }

        // Apply localization to the form
        private void ApplyLocalization()
        {
            this.Text = resourceManager.GetString("LocalEventsAndAnnouncementsTitle");
            backToMainMenuBtn.Text = resourceManager.GetString("BackToMainMenuBtn");
            searchBtn.Text = resourceManager.GetString("SearchBtn");
        }

        // Initialize data structures
        private void InitializeDataStructures()
        {
            eventsByDate = new SortedDictionary<DateTime, Queue<Event>>();
            uniqueCategories = new HashSet<string>();
            userSearchHistory = new Stack<string>();
            eventPriorityQueue = new PriorityQueue<Event, DateTime>();

        }

        // Load sample data
        private void LoadSampleData()
        {
            // Sample events
            Event event1 = new Event("Music Concert", "Entertainment", new DateTime(2024, 10, 15), "City Hall");
            Event event2 = new Event("Food Festival", "Food", new DateTime(2024, 11, 5), "Main Square");
            Event event3 = new Event("Tech Conference", "Technology", new DateTime(2024, 12, 1), "Convention Center");
            Event event4 = new Event("Art Exhibition", "Art", new DateTime(2024, 10, 20), "Art Gallery");
            Event event5 = new Event("Book Fair", "Literature", new DateTime(2024, 10, 18), "Public Library");
            Event event6 = new Event("Film Festival", "Entertainment", new DateTime(2024, 11, 10), "Movie Theater");
            Event event7 = new Event("Wine Tasting", "Food", new DateTime(2024, 11, 7), "Vineyard");
            Event event8 = new Event("Startup Pitch", "Technology", new DateTime(2024, 12, 3), "Tech Hub");
            Event event9 = new Event("Sculpture Workshop", "Art", new DateTime(2024, 10, 25), "Art Studio");
            Event event10 = new Event("Science Expo", "Education", new DateTime(2024, 11, 15), "Science Museum");
            Event event11 = new Event("Music Jam", "Entertainment", new DateTime(2024, 10, 22), "Concert Hall");
            Event event12 = new Event("Cooking Masterclass", "Food", new DateTime(2024, 11, 12), "Gourmet Kitchen");
            Event event13 = new Event("AI Symposium", "Technology", new DateTime(2024, 12, 6), "Innovation Center");
            Event event14 = new Event("Fashion Show", "Fashion", new DateTime(2024, 10, 28), "Fashion Street");
            Event event15 = new Event("Poetry Slam", "Literature", new DateTime(2024, 11, 2), "Poetry Cafe");

            AddEvent(event1);
            AddEvent(event2);
            AddEvent(event3);
            AddEvent(event4);
            AddEvent(event1);
            AddEvent(event2);
            AddEvent(event3);
            AddEvent(event4);
            AddEvent(event5);
            AddEvent(event6);
            AddEvent(event7);
            AddEvent(event8);
            AddEvent(event9);
            AddEvent(event10);
            AddEvent(event11);
            AddEvent(event12);
            AddEvent(event13);
            AddEvent(event14);
            AddEvent(event15);
        }

        // Method to add events to the data structures
        private void AddEvent(Event eventItem)
        {
            // Add to SortedDictionary (by date)
            if (!eventsByDate.ContainsKey(eventItem.Date))
            {
                eventsByDate[eventItem.Date] = new Queue<Event>();
            }
            eventsByDate[eventItem.Date].Enqueue(eventItem); // Add to queue for FIFO ordering

            // Add to PriorityQueue (based on event date)
            eventPriorityQueue.Enqueue(eventItem, eventItem.Date); // Add to priority queue (soonest events first)

            // Add to category HashSet (unique categories)
            uniqueCategories.Add(eventItem.Category);
        }

        // Display events in a ListBox (assume listBoxEvents is a ListBox control on your form)
        private void DisplayEvents()
        {
            listBoxEvents.Items.Clear(); // Clear previous items

            foreach (var dateQueue in eventsByDate)
            {
                foreach (var eventItem in dateQueue.Value)
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

        
        // Event handler for search buttons
        private void searchBtn_Click(object sender, EventArgs args)
        {
            ClearSearchResults();
            string searchTerm = searchTextBox.Text.Trim();
            List<Event> filteredEvents = GetEventsByName(searchTerm);
            DisplayEvents(filteredEvents);
        }
        private void ClearSearchResults()
        {
            listBoxEvents.Items.Clear(); // Clear the displayed events
            listBoxRecommendations.Items.Clear(); // Clear recommendations if needed
        }
        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            ClearSearchResults(); // Clear previous results
            DisplayEvents(); // Display all events
        }

        

        // Record user search for recommendations (use a stack to store the search history)
        private void RecordUserSearch(string category, DateTime date)
        {
            string searchQuery = $"{category}_{date.ToShortDateString()}";
            userSearchHistory.Push(searchQuery); // Push the search query to the stack
        }

        
        // Show event recommendations based on the user's search history
        private void ShowRecommendations(string selectedCategory)
        {
            listBoxRecommendations.Items.Clear(); // Clear previous recommendations

            // Check if a category is selected and display related events
            if (!string.IsNullOrEmpty(selectedCategory))
            {
                var recommendedEvents = eventsByDate
                    .SelectMany(kvp => kvp.Value) // Access all events
                    .Where(e => e.Category == selectedCategory) // Filter by the selected category
                    .ToList();

                // Display recommendations based on selected category
                foreach (var eventItem in recommendedEvents)
                {
                    listBoxRecommendations.Items.Add($"Recommended: {eventItem}");
                }
            }

            // Optionally, show past search recommendations from userSearchHistory
            foreach (var searchQuery in userSearchHistory)
            {
                listBoxRecommendations.Items.Add($"Based on search: {searchQuery}");
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

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            ClearSearchResults();
            DateTime selectedDate = dateTimePicker.Value.Date;
            List<Event> eventsOnSelectedDate = GetEventsOnDate(selectedDate);
            DisplayEvents(eventsOnSelectedDate);
        }
        private List<Event> GetEventsOnDate(DateTime date)
        {
            if (eventsByDate.ContainsKey(date))
            {
                return eventsByDate[date].ToList();
            }

            // Return events for the next 5 days
            List<Event> eventsInRange = new List<Event>();
            for (int i = 0; i < 6; i++) // Check current day and next 5 days
            {
                DateTime checkDate = date.AddDays(i);
                if (eventsByDate.ContainsKey(checkDate))
                {
                    eventsInRange.AddRange(eventsByDate[checkDate]);
                }
            }

            return eventsInRange;
        }

        // Get events by category
        private List<Event> GetEventsByCategory(string category)
        {
            if (string.IsNullOrEmpty(category))
            {
                return new List<Event>(); // Return empty if no category selected
            }

            return eventsByDate.Values.SelectMany(queue => queue)
                .Where(e => e.Category == category).ToList();
        }

        // Get events by name
        private List<Event> GetEventsByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return new List<Event>(); // Return empty if no search term
            }

            return eventsByDate.Values.SelectMany(queue => queue)
                .Where(e => e.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        // Display events in a ListBox (overloaded method)
        private void DisplayEvents(List<Event> eventsToDisplay)
        {
            listBoxEvents.Items.Clear(); // Clear previous items

            foreach (var eventItem in eventsToDisplay)
            {
                listBoxEvents.Items.Add(eventItem); // Display each event
            }

            UpdateCategoryComboBox(); // Update category dropdown if necessary
        }

        private void btnSearchByCategory_Click(object sender, EventArgs e)
        {
            ClearSearchResults();
            string selectedCategory = comboBoxCategories.SelectedItem?.ToString();
            List<Event> eventsInSelectedCategory = GetEventsByCategory(selectedCategory);
            DisplayEvents(eventsInSelectedCategory);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearSearchResults();
        }
    }

}
*/


using System.Collections.Generic;
using PROG7312ST10202241.Models;
using System;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using PROG7312ST10202241.Forms;

namespace PROG7312ST10202241
{
    public partial class LocalEventsAndAccouncementsForm : Form
    {
        private SortedDictionary<DateTime, Queue<Event>> eventsByDate;
        private HashSet<string> uniqueCategories;
        private Stack<string> userSearchHistory;
        private Dictionary<string, int> searchFrequency;
        private PriorityQueue<Event, DateTime> eventPriorityQueue;
        private ResourceManager resourceManager;


        public LocalEventsAndAccouncementsForm()
        {
            InitializeComponent();
            resourceManager = new ResourceManager("PROG7312ST10202241.Properties.Strings", typeof(LocalEventsAndAccouncementsForm).Assembly);
            ApplyLocalization();
            InitializeDataStructures();
            LoadSampleData(); // Load sample data instead of database data
            DisplayEvents(); // Display events on form load
        }

        // Apply localization to the form
        private void ApplyLocalization()
        {
            this.Text = resourceManager.GetString("LocalEventsAndAnnouncementsTitle");
            backToMainMenuBtn.Text = resourceManager.GetString("BackToMainMenuBtn");
            searchBtn.Text = resourceManager.GetString("SearchBtn");
        }

        // Initialize data structures
        private void InitializeDataStructures()
        {
            eventsByDate = new SortedDictionary<DateTime, Queue<Event>>();
            uniqueCategories = new HashSet<string>();
            userSearchHistory = new Stack<string>();
            searchFrequency = new Dictionary<string, int>(); // Track search frequency
            eventPriorityQueue = new PriorityQueue<Event, DateTime>();
        }

        // Load sample data
        private void LoadSampleData()
        {
            // Sample events
            Event event1 = new Event("Music Concert", "Entertainment", new DateTime(2024, 10, 15), "City Hall");
            Event event2 = new Event("Food Festival", "Food", new DateTime(2024, 11, 5), "Main Square");
            Event event3 = new Event("Tech Conference", "Technology", new DateTime(2024, 12, 1), "Convention Center");
            Event event4 = new Event("Art Exhibition", "Art", new DateTime(2024, 10, 20), "Art Gallery");
            Event event5 = new Event("Book Fair", "Literature", new DateTime(2024, 10, 18), "Public Library");
            Event event6 = new Event("Film Festival", "Entertainment", new DateTime(2024, 11, 10), "Movie Theater");
            Event event7 = new Event("Wine Tasting", "Food", new DateTime(2024, 11, 7), "Vineyard");
            Event event8 = new Event("Startup Pitch", "Technology", new DateTime(2024, 12, 3), "Tech Hub");
            Event event9 = new Event("Sculpture Workshop", "Art", new DateTime(2024, 10, 25), "Art Studio");
            Event event10 = new Event("Science Expo", "Education", new DateTime(2024, 11, 15), "Science Museum");
            Event event11 = new Event("Music Jam", "Entertainment", new DateTime(2024, 10, 22), "Concert Hall");
            Event event12 = new Event("Cooking Masterclass", "Food", new DateTime(2024, 11, 12), "Gourmet Kitchen");
            Event event13 = new Event("AI Symposium", "Technology", new DateTime(2024, 12, 6), "Innovation Center");
            Event event14 = new Event("Fashion Show", "Fashion", new DateTime(2024, 10, 28), "Fashion Street");
            Event event15 = new Event("Poetry Slam", "Literature", new DateTime(2024, 11, 2), "Poetry Cafe");

            AddEvent(event1);
            AddEvent(event2);
            AddEvent(event3);
            AddEvent(event4);
            AddEvent(event5);
            AddEvent(event6);
            AddEvent(event7);
            AddEvent(event8);
            AddEvent(event9);
            AddEvent(event10);
            AddEvent(event11);
            AddEvent(event12);
            AddEvent(event13);
            AddEvent(event14);
            AddEvent(event15);
        }

        // Method to add events to the data structures
        private void AddEvent(Event eventItem)
        {
            // Add to SortedDictionary (by date)
            if (!eventsByDate.ContainsKey(eventItem.Date))
            {
                eventsByDate[eventItem.Date] = new Queue<Event>();
            }
            eventsByDate[eventItem.Date].Enqueue(eventItem); // Add to queue for FIFO ordering

            // Add to PriorityQueue (based on event date)
            eventPriorityQueue.Enqueue(eventItem, eventItem.Date); // Add to priority queue (soonest events first)

            // Add to category HashSet (unique categories)
            uniqueCategories.Add(eventItem.Category);
        }

        // Display events in a ListBox (assume listBoxEvents is a ListBox control on your form)
        private void DisplayEvents()
        {
            listBoxEvents.Items.Clear(); // Clear previous items

            foreach (var dateQueue in eventsByDate)
            {
                foreach (var eventItem in dateQueue.Value)
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


        // Event handler for search buttons
        private void searchBtn_Click(object sender, EventArgs args)
        {
            ClearSearchResults();
            string searchTerm = searchTextBox.Text.Trim();
            List<Event> filteredEvents = GetEventsByName(searchTerm);
            DisplaySearchResults(filteredEvents);
            RecordUserSearch(searchTerm);
        }

        private void DisplaySearchResults(List<Event> eventsToDisplay)
        {
            listBoxRecommendations.Items.Clear(); // Clear previous recommendations

            foreach (var eventItem in eventsToDisplay)
            {
                listBoxRecommendations.Items.Add(eventItem); // Display each event in recommendations
            }
        }

        private void ClearSearchResults()
        {
            listBoxEvents.Items.Clear(); // Clear the displayed events
            listBoxRecommendations.Items.Clear(); // Clear recommendations
            comboBoxCategories.SelectedItem = null; // Clear category selection
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            ClearSearchResults(); // Clear previous results
            DisplayEvents(); // Display all events
        }

        // Record user search for recommendations (use a stack to store the search history)
        private void RecordUserSearch(string searchTerm)
        {
            userSearchHistory.Push(searchTerm); // Push the search query to the stack

            // Update search frequency
            if (searchFrequency.ContainsKey(searchTerm))
            {
                searchFrequency[searchTerm]++;
            }
            else
            {
                searchFrequency[searchTerm] = 1;
            }

            UpdateFrequentSearchRecommendations();
        }

        private void UpdateFrequentSearchRecommendations()
        {
            listBoxFrequentSearchRecommendations.Items.Clear(); // Clear previous recommendations

            // Sort searches by frequency and display top searches
            var sortedFrequencies = searchFrequency.OrderByDescending(kvp => kvp.Value).ToList();

            foreach (var search in sortedFrequencies)
            {
                listBoxFrequentSearchRecommendations.Items.Add($"Frequent: {search.Key} ({search.Value})");
            }
        }

        // Show event recommendations based on the user's search history
        private void ShowRecommendations(string selectedCategory)
        {
            listBoxRecommendations.Items.Clear(); // Clear previous recommendations

            // Check if a category is selected and display related events
            if (!string.IsNullOrEmpty(selectedCategory))
            {
                var recommendedEvents = eventsByDate
                    .SelectMany(kvp => kvp.Value) // Access all events
                    .Where(e => e.Category == selectedCategory) // Filter by the selected category
                    .ToList();

                // Display recommendations based on selected category
                foreach (var eventItem in recommendedEvents)
                {
                    listBoxRecommendations.Items.Add($"Recommended: {eventItem}");
                }
            }

            // Optionally, show past search recommendations from userSearchHistory
            foreach (var searchQuery in userSearchHistory)
            {
                listBoxRecommendations.Items.Add($"Based on search: {searchQuery}");
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

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            ClearSearchResults();
            DateTime selectedDate = dateTimePicker.Value.Date;
            List<Event> eventsOnSelectedDate = GetEventsOnDate(selectedDate);
            DisplaySearchResults(eventsOnSelectedDate);
        }

        private List<Event> GetEventsOnDate(DateTime date)
        {
            if (eventsByDate.ContainsKey(date))
            {
                return eventsByDate[date].ToList();
            }

            // Return events for the next 5 days
            List<Event> eventsInRange = new List<Event>();
            for (int i = 0; i < 6; i++) // Check current day and next 5 days
            {
                DateTime checkDate = date.AddDays(i);
                if (eventsByDate.ContainsKey(checkDate))
                {
                    eventsInRange.AddRange(eventsByDate[checkDate]);
                }
            }

            return eventsInRange;
        }

        // Get events by category
        private List<Event> GetEventsByCategory(string category)
        {
            if (string.IsNullOrEmpty(category))
            {
                return new List<Event>(); // Return empty if no category selected
            }

            return eventsByDate.Values.SelectMany(queue => queue)
                .Where(e => e.Category == category).ToList();
        }

        // Get events by name
        private List<Event> GetEventsByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return new List<Event>(); // Return empty if no search term
            }

            return eventsByDate.Values.SelectMany(queue => queue)
                .Where(e => e.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        private void btnSearchByCategory_Click(object sender, EventArgs e)
        {
            ClearSearchResults();
            string selectedCategory = comboBoxCategories.SelectedItem?.ToString();
            List<Event> eventsInSelectedCategory = GetEventsByCategory(selectedCategory);
            DisplaySearchResults(eventsInSelectedCategory);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearSearchResults();
            searchTextBox.Text = string.Empty; // Clear search text
        }
    }
}


