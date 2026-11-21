using System;

namespace AutoService.Models;

public class PerformedWork
{
    public int Id { get; private set; }
    public int AppointmentId { get; private set; }
    public int WorkTypeId { get; private set; }
    public decimal ActualHours { get; private set; }
    public decimal TotalPrice { get; private set; }

    private PerformedWork(int appointmentId, int workTypeId, decimal actualHours, decimal totalPrice)
    {
        AppointmentId = appointmentId;
        WorkTypeId = workTypeId;
        ActualHours = actualHours;
        TotalPrice = totalPrice;
    }

    public static PerformedWork Create(int? appointmentId, int? workTypeId, decimal? actualHours, decimal? totalPrice)
    {
        if (appointmentId == null) throw new ArgumentNullException(nameof(appointmentId), "ID записи не может быть null.");
        if (workTypeId == null) throw new ArgumentNullException(nameof(workTypeId), "ID вида работы не может быть null.");
        if (actualHours == null) throw new ArgumentNullException(nameof(actualHours), "Фактические часы не могут быть null.");
        if (totalPrice == null) throw new ArgumentNullException(nameof(totalPrice), "Стоимость не может быть null.");

        if (appointmentId <= 0) throw new ArgumentException("Некорректный ID записи.");
        if (workTypeId <= 0) throw new ArgumentException("Некорректный ID вида работы.");
        if (actualHours < 0) throw new ArgumentException("Фактические часы не могут быть отрицательными.");
        if (totalPrice < 0) throw new ArgumentException("Стоимость не может быть отрицательной.");

        return new PerformedWork(appointmentId.Value, workTypeId.Value, actualHours.Value, totalPrice.Value);
    }

    internal void SetId(int id) => Id = id;
}