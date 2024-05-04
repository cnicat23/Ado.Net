using Business.Services.Abstracts;
using Business.Services.Concrets;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Controllers
{
    public class ProductController
    {
        IProductService _productService = new ProductService();

        public void AddProduct()
        {
            Console.WriteLine("Enter Product Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Product Description");
            string description = Console.ReadLine();

            Console.WriteLine("Enter Product Category");
            string category = Console.ReadLine();

            Product product = new Product()
            {
                Name = name,
                Description = description,
                Category = category
            };
            _productService.AddProduct(product);
        }

        public void DeleteProduct()
        {
            Console.WriteLine("Enter Product Id");
            int id = int.Parse(Console.ReadLine());

            _productService.DeleteProduct(id);
        }

        public void UpdateProduct()
        {
            Console.WriteLine("Enter Product Id");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Product Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Product Description");
            string description = Console.ReadLine();

            Console.WriteLine("Enter Product Category");
            string category = Console.ReadLine();

            Product newProduct = new Product()
            {
                Id = id,
                Name = name,
                Description = description,
                Category = category
            };
            _productService.UpdateProduct(id, newProduct);
        }

        public void GetProduct()
        {
            Console.WriteLine("Enter student id: ");
            int id = int.Parse(Console.ReadLine());

            Product product = _productService.GetProduct(id);

            Console.WriteLine($"{product.Id} - {product.Name} - {product.Description} - {product.Category}");
        }

        public void GetAllProducts()
        {
            foreach (var item in _productService.GetAllProduct())
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Description} - {item.Category}");
            }
        }
    }
}
