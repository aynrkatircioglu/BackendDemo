using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetAllByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDTO>> GetProductDetails();
        IDataResult<Product>GetById(int productId);
        IResult Add(Product product);
        IDataResult<List<Product>> GetProducts(); 
        IResult Update(Product product);
        IResult AddTransactionalTest(Product product);


    }
}
