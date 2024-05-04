using Business.Services.Abstracts;
using Core.Models;
using Core.RepositoryAbstract;
using Data.RepositoryConcrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Concrets
{
    public class ProductService : IProductService
    {
        İProductRepository _productRepository = new ProductRepository();
        public void AddProduct(Product product)
        {
            string command = $"insert into Product(Name, Description, Category) " +
                $"values ('{product.Name}', '{product.Description}', '{product.Category}')";
            _productRepository.Add(command);
        }

        public void DeleteProduct(int id)
        {
            string command = $"delete from Product where Id = {id}";
            _productRepository.Delete(command);
        }

        public List<Product> GetAllProduct()
        {
            string command = "select * from Product";
            return _productRepository.GetAll(command);
        }

        public Product GetProduct(int id)
        {
            string command = $"select * from Product where Id = {id}";
            return _productRepository.Get(command);
        }

        public void UpdateProduct(int id, Product newProduct)
        {
            string command = $"select * from Product where Id = {id}";
            Product product = _productRepository.Get(command);

            if (product == null) throw new NullReferenceException();

            product.Name = newProduct.Name;
            product.Description = newProduct.Description;
            product.Category = newProduct.Category;

            string updateCommand = $"update Product set Id = {product.Id}, Name = '{product.Name}', " +
                $"Description = '{product.Description}', Category = '{product.Category}'";
            _productRepository.Update(updateCommand);
        }
    }
}
