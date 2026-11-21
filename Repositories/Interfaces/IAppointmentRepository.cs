using System.Collections.Generic;
using AutoService.Models;

namespace AutoService.Repositories.Interfaces
{
    public interface IAppointmentRepository
    {
        List<Appointment> GetAll();
        void Add(Appointment appointment);
    }
}