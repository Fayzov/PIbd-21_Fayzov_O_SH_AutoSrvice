using System;

namespace AutoService.Models
{
    public class Car
    {
        public int Id { get; private set; }
        public int ClientId { get; private set; }
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public string CarNumbers { get; private set; }

        private Car(int clientId, string brand, string model, string carNumbers)
        {
            ClientId = clientId;
            Brand = brand;
            Model = model;
            CarNumbers = carNumbers;
        }

        public static Car Create(int? clientId, string? brand, string? model, string? carNumbers)
        {
            if (clientId == null) throw new ArgumentNullException(nameof(clientId), "ID клиента не может быть null.");
            if (brand == null) throw new ArgumentNullException(nameof(brand), "Марка не может быть null.");
            if (model == null) throw new ArgumentNullException(nameof(model), "Модель не может быть null.");
            if (carNumbers == null) throw new ArgumentNullException(nameof(carNumbers), "Номер авто не может быть null.");

            if (clientId <= 0) throw new ArgumentException("Некорректный ID клиента.");
            if (string.IsNullOrWhiteSpace(brand)) throw new ArgumentException("Марка не может быть пустой.");
            if (string.IsNullOrWhiteSpace(model)) throw new ArgumentException("Модель не может быть пустой.");
            if (string.IsNullOrWhiteSpace(carNumbers)) throw new ArgumentException("Номер авто не может быть пустым.");

            return new Car(clientId.Value, brand, model, carNumbers);
        }

        internal void SetId(int id) => Id = id;
    }
}