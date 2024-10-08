﻿using DataAccess.Abstract;
using DataAccess.Concrete.EntityFremwork;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Product { ProductId = 1, CategoryId = 1, ProductName = "Bardak", UnitPrice = 15, UnitsInStock = 8},

                new Product { ProductId = 1, CategoryId = 1, ProductName = "Fare", UnitPrice = 25, UnitsInStock = 5 },

                new Product { ProductId = 2, CategoryId = 1, ProductName = "Telefon", UnitPrice = 50, UnitsInStock = 3 },

                new Product { ProductId = 3, CategoryId = 2, ProductName = "Kamera", UnitPrice = 500, UnitsInStock = 2 },

                new Product { ProductId = 4, CategoryId = 2, ProductName = "Klavye", UnitPrice = 35, UnitsInStock = 85 }
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
            productToUpdate.CategoryId = product.CategoryId;

        }

          public List<Product> GetAllByCetagory(int categoryId)
        {
         return _products.Where (p=> p.CategoryId== categoryId).ToList();

        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
