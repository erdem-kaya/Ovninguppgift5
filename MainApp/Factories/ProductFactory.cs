
using MainApp.Dtos;
using MainApp.Interfaces;
using MainApp.Models;

namespace MainApp.Interfaces
{
    public class ProductFactory : IProductFactory
    {
        private static int _idCounter = 0;

        public Product Create(ProductDto productDto)
        {
            return new Product
            {
                Id = _idCounter++,
                Name = productDto.Name,
                Price = productDto.Price
            };
        }
    }
}
