using ProjetoBase.Domain.Products.ValueObjects;
using ProjetoBase.Shared.Bases.BaseEntity;
using System;

namespace ProjetoBase.Domain.Products.Entities
{
    public class Product : Entity
    {
        public ProductInformation ProductInformation { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime AddDate { get; set; }
        public bool HasInStock { get; set; }

        public Product(ProductInformation productInformation, double price, int quantity, DateTime expirationDate)
        {
            ProductInformation = productInformation;
            Price = price;
            Quantity = quantity;
            ExpirationDate = expirationDate;
            HasInStock = true;
            AddDate = DateTime.Now;
        }
    }
}
