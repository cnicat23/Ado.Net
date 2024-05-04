using Core.Models;
using Core.RepositoryAbstract;
using Data.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepositoryConcrets
{
    public class ProductRepository : İProductRepository
    {
        AppDbContext _appDbContext = new AppDbContext();
        public void Add(string command)
        {
            _appDbContext.NonQuery(command);
        }

        public void Delete(string command)
        {
            _appDbContext.NonQuery(command);
        }

        public Product Get(string command)
        {
            var dt = _appDbContext.Query(command);
            List<Product> products = new List<Product>();
            foreach (DataRow item in dt.Rows)
            {
                Product product = new Product
                {
                    Id = int.Parse(item[0].ToString()),
                    Name = item[1].ToString(),
                    Description = item[2].ToString(),
                    Category = item[3].ToString(),
                };
                products.Add(product);
            }
            return products[0];
        }

        public List<Product> GetAll(string command)
        {
            var dt = _appDbContext.Query(command);
            List<Product> products = new List<Product>();
            foreach (DataRow item in dt.Rows)
            {
                Product product = new Product
                {
                    Id = int.Parse(item[0].ToString()),
                    Name = item[1].ToString(),
                    Description = item[2].ToString(),
                    Category = item[3].ToString(),
                };
                products.Add(product);
            }
            return products;
        }

        public void Update(string command)
        {
            _appDbContext.NonQuery(command);
        }
    }
}
