using ProjetoBase.Shared.Bases.BaseValueObjects;

namespace ProjetoBase.Domain.Products.ValueObjects
{
    public class ProductInformation : ValueObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
