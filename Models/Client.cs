using System;

namespace AutoService.Models
{
    public class Client
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Phone { get; private set; }

        private Client(string name, string surname, string phone)
        {
            Name = name;
            Surname = surname;
            Phone = phone;
        }

        public static Client Create(string? name, string? surname, string? phone)
        {
            if (name == null) throw new ArgumentNullException(nameof(name), "Имя не может быть null.");
            if (surname == null) throw new ArgumentNullException(nameof(surname), "Фамилия не может быть null.");
            if (phone == null) throw new ArgumentNullException(nameof(phone), "Телефон не может быть null.");

            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Имя не может быть пустым.");
            if (string.IsNullOrWhiteSpace(surname)) throw new ArgumentException("Фамилия не может быть пустой.");
            if (string.IsNullOrWhiteSpace(phone)) throw new ArgumentException("Телефон не может быть пустым.");

            foreach (char c in phone)
            {
                if (!char.IsDigit(c) && c != '+' && c != '-' && c != ' ')
                {
                    throw new ArgumentException("Телефон должен содержать только цифры, пробелы, '+' или '-'.");
                }
            }

            if (phone.Trim().Length < 5)
                throw new ArgumentException("Телефон слишком короткий.");

            return new Client(name, surname, phone);
        }

        internal void SetId(int id) => Id = id;
    }
}