using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Location = location;
                    Category = category;
                    Description = description;
                    MediaAttachmentPath = mediaAttachmentPath;
                }
       
        

        public override string ToString()
        {
            return $"Location: {Location}, Category: {Category}, Description: {Description}, Media: {MediaAttachmentPath}";
        }
    }
}
     