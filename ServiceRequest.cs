using System;

namespace PROG7312ST10202241
{
    public class ServiceRequest
    {
        public int RequestId { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime SubmittedDate { get; set; }
    }
}
