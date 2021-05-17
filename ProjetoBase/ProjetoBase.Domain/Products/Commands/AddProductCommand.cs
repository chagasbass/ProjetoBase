using System;

namespace ProjetoBase.Domain.Products.Commands
{
    public class AddProductCommand
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public DateTime ExpirationDate { get; set; }

        public AddProductCommand()
        {

        }
    }
}
