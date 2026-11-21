using System;

namespace AutoService.Models
{
    public class Appointment
    {
        public int Id { get; private set; }
        public int CarId { get; private set; }
        public int MechanicId { get; private set; }
        public DateTime AppointmentDate { get; private set; }

        private Appointment(int carId, int mechanicId, DateTime appointmentDate)
        {
            CarId = carId;
            MechanicId = mechanicId;
            AppointmentDate = appointmentDate;
        }

        public static Appointment Create(int? carId, int? mechanicId, DateTime? appointmentDate)
        {
            if (carId == null) throw new ArgumentNullException(nameof(carId), "ID автомобиля не может быть null.");
            if (mechanicId == null) throw new ArgumentNullException(nameof(mechanicId), "ID механика не может быть null.");
            if (appointmentDate == null) throw new ArgumentNullException(nameof(appointmentDate), "Дата не может быть null.");

            if (carId <= 0) throw new ArgumentException("Некорректный ID автомобиля.");
            if (mechanicId <= 0) throw new ArgumentException("Некорректный ID механика.");
            if (appointmentDate == default) throw new ArgumentException("Дата записи не может быть пустой.");

            return new Appointment(carId.Value, mechanicId.Value, appointmentDate.Value);
        }

        internal void SetId(int id) => Id = id;
    }
}