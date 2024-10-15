using PROG7312ST10202241.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class DatabaseHelper
{
    public static void InitializeDatabase()
    {
        // Initialization code here if needed, like table creation if not exists
    }

    /* public static List<Event> GetAllEvents()
     {
         List<Event> events = new List<Event>();
         using (SqlConnection connection = new SqlConnection(connectionString))
         {
             connection.Open();
             string selectQuery = "SELECT * FROM Events";
             SqlCommand command = new SqlCommand(selectQuery, connection);
             using (SqlDataReader reader = command.ExecuteReader())
             {
                 while (reader.Read())
                 {
                     Event eventItem = new Event(
                         reader["Title"].ToString(),
                         reader["Category"].ToString(),
                         DateTime.Parse(reader["EventDate"].ToString()),
                         reader["Location"].ToString()
                     );
                     events.Add(eventItem);
                 }
             }
         }
         return events;
     }

     public static void AddEventToDatabase(Event eventItem)
     {
         using (SqlConnection connection = new SqlConnection(connectionString))
         {
             connection.Open();
             string insertQuery = @"INSERT INTO Events (Title, Category, EventDate, Location) 
                                    VALUES (@Title, @Category, @EventDate, @Location)";
             SqlCommand command = new SqlCommand(insertQuery, connection);
             command.Parameters.AddWithValue("@Title", eventItem.Title);
             command.Parameters.AddWithValue("@Category", eventItem.Category);
             command.Parameters.AddWithValue("@EventDate", eventItem.Date);
             command.Parameters.AddWithValue("@Location", eventItem.Location);
             command.ExecuteNonQuery();
         }
     }

     public static List<Event> SearchEvents(string category, DateTime? selectedDate, string searchText)
     {
         List<Event> events = new List<Event>();
         using (SqlConnection connection = new SqlConnection(connectionString))
         {
             connection.Open();
             string query = @"SELECT * FROM Events WHERE 
                             (@Category IS NULL OR Category = @Category) AND 
                             (@SearchText IS NULL OR Title LIKE '%' + @SearchText + '%' OR Location LIKE '%' + @SearchText + '%' OR Category LIKE '%' + @SearchText + '%') AND 
                             (@SelectedDate IS NULL OR EventDate = @SelectedDate)";

             SqlCommand command = new SqlCommand(query, connection);
             command.Parameters.AddWithValue("@Category", string.IsNullOrEmpty(category) ? (object)DBNull.Value : category);
             command.Parameters.AddWithValue("@SearchText", string.IsNullOrEmpty(searchText) ? (object)DBNull.Value : searchText);
             command.Parameters.AddWithValue("@SelectedDate", selectedDate.HasValue ? (object)selectedDate.Value : DBNull.Value);

             using (SqlDataReader reader = command.ExecuteReader())
             {
                 while (reader.Read())
                 {
                     Event eventItem = new Event(
                         reader["Title"].ToString(),
                         reader["Category"].ToString(),
                         DateTime.Parse(reader["EventDate"].ToString()),
                         reader["Location"].ToString()
                     );
                     events.Add(eventItem);
                 }
             }
         }
         return events;
     }
    */
}
