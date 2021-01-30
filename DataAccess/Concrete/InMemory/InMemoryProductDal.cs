using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; //global değişkenleri _ çizgi ile veririz
        public InMemoryProductDal()
        {
            //Oracle,Sql Server, Postgres, MongoDb
            _products = new List<Product> {
                new Product{ProductId =1, CategorId=1, ProductName = "Bardak", UnitPrice = 15, UnitsInStock =15},
                new Product{ProductId =2, CategorId=1, ProductName = "Kamera", UnitPrice = 500, UnitsInStock =3},
                new Product{ProductId =3, CategorId=1, ProductName = "Telefon", UnitPrice = 1500, UnitsInStock =2},
                new Product{ProductId =4, CategorId=1, ProductName = "Klavye", UnitPrice = 150, UnitsInStock =65},
                new Product{ProductId =5, CategorId=1, ProductName = "Fare", UnitPrice = 85, UnitsInStock =1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ - Language Integrated Query
            //Lambda (=>)
            
            //Product productToDelete = null;
            //foreach (var p in _products)
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}

            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);//sizin yerinize products tek tek dolaşı  (her p için git bak bayım p nin productid si
                                                                                                   //benim gönderdiğim productid ye eşit mi)
            _products.Remove(product);
        }

        public List<Product> GetALL()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p=>p.CategorId==categoryId).ToList(); //yeni bir liste haline getirir onu döndürür
        }

        public void Update(Product product)
        {
            //gönderdiğim ürün id'sine sahip olan listedeki ürün id'sini bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategorId = product.CategorId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
