using System;

namespace AutoService.Models
{
    public class UsedPartDisplayItem
    {
        public int Id { get; set; }
        public string AppointmentInfo { get; set; } = string.Empty;
        public string CarPartInfo { get; set; } = string.Empty;
        public int Quantity { get; set; }
    }
}