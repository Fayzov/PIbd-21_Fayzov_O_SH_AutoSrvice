using System;

namespace AutoService.Models
{
    public class AppointmentDisplayItem
    {
        public int Id { get; set; }
        public string CarInfo { get; set; }
        public string MechanicInfo { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}