using System;
using System.IO;

namespace PROG7312ST10202241
{
    public class IssueReport
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string MediaAttachmentPath { get; set; }

        public IssueReport(string location, string category, string description, string mediaAttachmentPath)
        {
            if (string.IsNullOrWhiteSpace(location))
                throw new ArgumentException("Location is required.");
            if (string.IsNullOrWhiteSpace(category))
                throw new ArgumentException("Category is required.");
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Description is required.");

            Location = location;
            Category = category;
            Description = description;

            if (!string.IsNullOrWhiteSpace(mediaAttachmentPath))
            {
                if (!File.Exists(mediaAttachmentPath))
                    throw new FileNotFoundException("Media file not found.", mediaAttachmentPath);
                MediaAttachmentPath = mediaAttachmentPath;
            }
        }

        public override string ToString()
        {
            return $"Location: {Location}, Category: {Category}, Description: {Description}, Media: {MediaAttachmentPath}";
        }
    }
}
