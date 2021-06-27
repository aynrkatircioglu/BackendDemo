using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal :IProductDal
    {
        //veri vamrış gibi davranacağımızdan bir ürün lsitesi oluşturalım
        private List<Product> _products;
        //ORacle, sql serveri postgres, mongodb
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId = 1, CategoryId = 1, ProductName = "Bardak", UnitPrice = 15, UnitsInStock= 15},
                new Product{ProductId = 2, CategoryId = 1, ProductName = "Kamera", UnitPrice = 500, UnitsInStock = 3},
                new Product{ProductId = 3, CategoryId = 2, ProductName = "Telefon", UnitPrice = 1500, UnitsInStock = 2},
                new Product{ProductId = 4, CategoryId = 2, ProductName = "Klavye", UnitPrice = 150, UnitsInStock = 65},
                new Product{ProductId = 5, CategoryId = 2, ProductName = "Fare", UnitPrice = 85, UnitsInStock = 1},
            };
        }
        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            _products.Add(product); //şu an veritabanı liste olduğundna böyle yaptık
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;


        }










        public void Delete(Product product)
        {
            //LINQ - language integrated query

            // Product productToDelete = null; //referans numarası atama

            //foreach (var p in _products) //bu döngü ile listeyi tek tek dolaşabiliyorsun
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //} //linq olmasaydı bu kodu böyle listeyi tek tek dolaşarak yapacaktık. 


            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);
            //SingleOrDefault productsı tek tek dolaşmaya yarar
                _products.Remove(product);
            }

        public List<ProductDetailDTO> GetProductDetails()
        {
            throw new NotImplementedException();
        }


        public List<Product> GetAllByCategory(int CategoryId)
        {
           return  _products.Where(p => p.CategoryId == CategoryId).ToList();
           //where koşulu: içindeki şarta uyan tüm elemanlşarı yeni bir liste haline getirip onu döndürür.
        }
    }
    }

