

using MainApp.Dtos;
using MainApp.Factories;
using MainApp.Interfaces;
using MainApp.Models;

namespace MainApp.Services;

public class ProductService : IProductService
{
    private readonly ProductFactory _productFactory;
    private readonly List<Product> _products;

    public ProductService(ProductFactory productFactory)
    {
        _productFactory = productFactory;
        _products = new List<Product>();
    }


    public bool AppProduct(ProductDto productDto)
    {
        var product = _productFactory.Create(productDto);
        _products.Add(product);
        return true;
    }

    public List<Product> GetAllProducts()
    {
        return _products;
    }

    public Product GetProductById(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id) ?? throw new Exception("Product not found");
        return product;
    }
}
