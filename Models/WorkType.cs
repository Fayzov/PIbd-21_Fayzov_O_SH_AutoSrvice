using System;

namespace AutoService.Models
{
    public class WorkType
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public decimal Hours { get; private set; }
        public decimal Price { get; private set; }

        private WorkType(string name, decimal hours, decimal price)
        {
            Name = name;
            Hours = hours;
            Price = price;
        }

        public static WorkType Create(string? name, decimal? hours, decimal? price)
        {
            if (name == null) throw new ArgumentNullException(nameof(name), "Название работы не может быть null.");
            if (hours == null) throw new ArgumentNullException(nameof(hours), "Нормо-часы не могут быть null.");
            if (price == null) throw new ArgumentNullException(nameof(price), "Стоимость не может быть null.");

            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Название работы не может быть пустым.");
            if (hours <= 0) throw new ArgumentException("Нормо-часы должны быть больше нуля.");
            if (price < 0) throw new ArgumentException("Стоимость не может быть отрицательной.");

            return new WorkType(name, hours.Value, price.Value);
        }

        internal void SetId(int id) => Id = id;
    }
}