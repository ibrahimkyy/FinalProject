using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.İnMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        private Product productsToDelete;

        public InMemoryProductDal()
        {
            _products = new List<Product>

            {
                new Product { ProductId = 1, CatagoryId = 1, ProductName = "Bardak", UnitPrice = 15, UnitsInStock = 8},

                new Product { ProductId = 1, CatagoryId = 1, ProductName = "Fare", UnitPrice = 25, UnitsInStock = 5 },

                new Product { ProductId = 2, CatagoryId = 1, ProductName = "Telefon", UnitPrice = 50, UnitsInStock = 3 },

                new Product { ProductId = 3, CatagoryId = 2, ProductName = "Kamera", UnitPrice = 500, UnitsInStock = 2 },

                new Product { ProductId = 4, CatagoryId = 2, ProductName = "Klavye", UnitPrice = 35, UnitsInStock = 85 }
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)

        {



            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);


            _products.Remove(productToDelete);

        }



        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.ProductId = product.ProductId;
            productToUpdate.CatagoryId = product.CatagoryId;

        }

          public List<Product> GetAllByCatagory(int catagoryId)
        {
         return _products.Where (p=> p.CatagoryId== catagoryId).ToList();

        }

    }
}
