using MainApp.Dtos;
using MainApp.Models;

namespace MainApp.Interfaces
{
    public interface IProductService
    {
        bool AppProduct(ProductDto productDto);
        Product GetProductById(int id);
        List<Product> GetAllProducts();

    }
}
