using System;
using AutoService.Enums;

namespace AutoService.Models
{
    public class Mechanic
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public Qualification Qualification { get; private set; }
        public int ExperienceYear { get; private set; }

        private Mechanic(string name, string surname, Qualification qualification, int experienceYear)
        {
            Name = name;
            Surname = surname;
            Qualification = qualification;
            ExperienceYear = experienceYear;
        }

        public static Mechanic Create(string? name, string? surname, Qualification? qualification, int? experienceYear)
        {
            if (name == null) throw new ArgumentNullException(nameof(name), "Имя не может быть null.");
            if (surname == null) throw new ArgumentNullException(nameof(surname), "Фамилия не может быть null.");
            if (qualification == null) throw new ArgumentNullException(nameof(qualification), "Квалификация не может быть null.");
            if (experienceYear == null) throw new ArgumentNullException(nameof(experienceYear), "Стаж не может быть null.");

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Имя не может быть пустым.");
            if (string.IsNullOrWhiteSpace(surname))
                throw new ArgumentException("Фамилия не может быть пустой.");
            if (experienceYear < 0)
                throw new ArgumentException("Стаж не может быть отрицательным.");

            return new Mechanic(name, surname, qualification.Value, experienceYear.Value);
        }

        internal void SetId(int id) => Id = id;
    }
}