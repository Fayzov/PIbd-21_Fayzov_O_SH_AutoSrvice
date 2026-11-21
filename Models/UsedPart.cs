using System;

namespace AutoService.Models
{
    public class UsedPart
    {
        public int Id { get; private set; }
        public int AppointmentId { get; private set; }
        public int CarPartId { get; private set; }
        public int Quantity { get; private set; }

        private UsedPart(int appointmentId, int carPartId, int quantity)
        {
            AppointmentId = appointmentId;
            CarPartId = carPartId;
            Quantity = quantity;
        }

        public static UsedPart Create(int? appointmentId, int? carPartId, int? quantity)
        {
            if (appointmentId == null) throw new ArgumentNullException(nameof(appointmentId), "ID записи не может быть null.");
            if (carPartId == null) throw new ArgumentNullException(nameof(carPartId), "ID запчасти не может быть null.");
            if (quantity == null) throw new ArgumentNullException(nameof(quantity), "Количество не может быть null.");

            if (appointmentId <= 0) throw new ArgumentException("Некорректный ID записи.");
            if (carPartId <= 0) throw new ArgumentException("Некорректный ID запчасти.");
            if (quantity <= 0) throw new ArgumentException("Количество запчастей должно быть больше нуля.");

            return new UsedPart(appointmentId.Value, carPartId.Value, quantity.Value);
        }

        internal void SetId(int id) => Id = id;
    }
}