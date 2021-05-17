using ProjetoBase.Domain.Products.Entities;
using System.Threading.Tasks;

namespace ProjetoBase.Domain.Products.Repositories
{
    public interface IProductRepository
    {
        Task<Product> SaveProductAsync(Product product);
    }
}
