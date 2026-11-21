using System;

namespace AutoService.Models
{
    public class CarPart
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Article { get; private set; }
        public decimal Price { get; private set; }
        public int StockQuantity { get; private set; }

        private CarPart(string name, string article, decimal price, int stockQuantity)
        {
            Name = name;
            Article = article;
            Price = price;
            StockQuantity = stockQuantity;
        }

        public static CarPart Create(string? name, string? article, decimal? price, int? stockQuantity)
        {
            if (name == null) throw new ArgumentNullException(nameof(name), "Название запчасти не может быть null.");
            if (article == null) throw new ArgumentNullException(nameof(article), "Артикул не может быть null.");
            if (price == null) throw new ArgumentNullException(nameof(price), "Цена не может быть null.");
            if (stockQuantity == null) throw new ArgumentNullException(nameof(stockQuantity), "Количество не может быть null.");

            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Введите название запчасти");
            if (string.IsNullOrWhiteSpace(article)) throw new ArgumentException("Введите артикул запчасти");
            if (price < 0) throw new ArgumentException("Цена не может быть отрицательной");
            if (stockQuantity < 0) throw new ArgumentException("Количество на складе не может быть отрицательным");

            return new CarPart(name, article, price.Value, stockQuantity.Value);
        }

        internal void SetId(int id) => Id = id;
    }
}