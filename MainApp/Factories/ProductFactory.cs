
using MainApp.Dtos;
using MainApp.Models;

namespace MainApp.Factories
{
    public  class ProductFactory
    {
        private static int _idCounter = 0;
        public ProductDto Create()
        {
            return new();
        }

        public Product Create(ProductDto productDto)
        {
            return new()
            {
                Id = _idCounter++,
                Name = productDto.Name,
                Price = productDto.Price
            };
        }
    }
}
