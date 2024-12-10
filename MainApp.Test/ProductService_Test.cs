
using MainApp.Dtos;
using MainApp.Interfaces;
using MainApp.Interfaces;
using MainApp.Models;
using MainApp.Services;
using Moq;

namespace MainApp.Test
{
    public class ProductService_Test
    {
        private readonly Mock<IProductFactory> _productFactoryMock;
        private readonly IProductService _services;

        public ProductService_Test()
        {
            _productFactoryMock = new Mock<IProductFactory>();
            _services = new ProductService(_productFactoryMock.Object);
        }
    

    [Fact]
        public void AddProduct_ShouldAddProductToList()
        {
            // Arrange
            var productDto = new ProductDto { Name = "Product 1", Price = 100 };
            var product = new Product { Id = 1, Name = "Product 1", Price = 100 };

       
            _productFactoryMock.Setup(x => x.Create(productDto)).Returns(product);

            
            // Act
            _services.AddProduct(productDto);


            // Assert
            var products = _services.GetAllProducts();
            Assert.Single(products);
        }


        [Fact]
        public void GetProductById_ShouldReturnProduct()
        {
            // Arrange
            var productDto = new ProductDto { Name = "Product 1", Price = 100 };
            var product = new Product { Id = 1, Name = "Product 1", Price = 100 };
            _productFactoryMock.Setup(x => x.Create(productDto)).Returns(product);
            _services.AddProduct(productDto);
            // Act
            var result = _services.GetProductById(1);
            // Assert
            Assert.Equal(product, result);
        }


        [Fact]
        public void GetAllProducts_ShouldReturnAllProducts()
        {
            // Arrange
            var productDto1 = new ProductDto { Name = "Product 1", Price = 100 };
            var productDto2 = new ProductDto { Name = "Product 2", Price = 200 };
            var product1 = new Product { Id = 1, Name = "Product 1", Price = 100 };
            var product2 = new Product { Id = 2, Name = "Product 2", Price = 200 };
            _productFactoryMock.Setup(x => x.Create(productDto1)).Returns(product1);
            _productFactoryMock.Setup(x => x.Create(productDto2)).Returns(product2);
            _services.AddProduct(productDto1);
            _services.AddProduct(productDto2);
            // Act
            var result = _services.GetAllProducts();
            // Assert
            Assert.Equal(2, result.Count);
            Assert.Contains(product1, result);
            Assert.Contains(product2, result);
        }
    }
}
