using ProjetoBase.Domain.Products.Commands;
using System.Threading.Tasks;

namespace ProjetoBase.Domain.Products.Services
{
    public interface IProductService
    {
        Task<AddProductCommand> SaveProductAsync(AddProductCommand addProductCommand);
    }
}
