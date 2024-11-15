﻿namespace PROG7312ST10202241
{
    public class ServiceRequest
    {
        public int RequestId { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }

        public override string ToString()
        {
            return $"RequestID: {RequestId}, Status: {Status}, Description: {Description}, Priority: {Priority}";
        }
    }
}
