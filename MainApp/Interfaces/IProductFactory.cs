using MainApp.Dtos;
using MainApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Interfaces
{
    public interface IProductFactory
    {
        Product Create(ProductDto productDto);
    }
}
