using System.Collections.Generic;
using AutoService.Models;
using AutoService.Repositories.Interfaces;

namespace AutoService.Repositories.Stubs
{
    public class AppointmentRepositoryStub : IAppointmentRepository
    {
        private readonly List<Appointment> _appointments = new List<Appointment>();
        private int _nextId = 1;

        public List<Appointment> GetAll() => _appointments;

        public void Add(Appointment appointment)
        {
            appointment.SetId(_nextId++);
            _appointments.Add(appointment);
        }
    }
}