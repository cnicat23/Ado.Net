using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.RepositoryAbstract
{
    public interface İProductRepository
    {
        void Add(string command);
        void Delete(string command);
        void Update(string command);
        Product Get(string command);
        List<Product> GetAll(string command);
    }
}
