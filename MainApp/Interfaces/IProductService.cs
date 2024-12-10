using MainApp.Dtos;
using MainApp.Models;

namespace MainApp.Interfaces
{
    public interface IProductService
    {
        bool AddProduct(ProductDto productDto);
        Product GetProductById(int id);
        List<Product> GetAllProducts();

    }
}
