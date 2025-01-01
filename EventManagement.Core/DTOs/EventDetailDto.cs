using System;

namespace EventManagement.Core.DTOs
{
    public class EventDetailDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public string Category { get; set; }
        public string OrganizerName { get; set; }
        public int RegisteredCount { get; set; }
        public double AverageRating { get; set; }
    }
}
