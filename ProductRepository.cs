using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Session01_AdvancedC_
{
    internal class ProductRepository : IReposatory<Product>
    {

        private List<Product> products = new List<Product>();

        public void Add(Product item)
        {
            products.Add(item);
        }

        public void Remove(Product item)
        {
            products.Remove(item);
        }

        public Product GetById(int id)
        {
            return products.Find(p => p.Id == id);
        }

        public IEnumerable<Product> GetAll()
            => products;

    }
}

