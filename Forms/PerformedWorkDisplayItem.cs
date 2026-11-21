using System;

namespace AutoService.Models
{
    public class PerformedWorkDisplayItem
    {
        public int Id { get; set; }
        public string AppointmentInfo { get; set; } = string.Empty;
        public string WorkTypeInfo { get; set; } = string.Empty;
        public decimal ActualHours { get; set; }
        public decimal TotalPrice { get; set; }
    }
}