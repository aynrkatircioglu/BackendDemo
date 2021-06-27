using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
using Entities;

namespace DataAccess.Abstract
{
   public class ICustomerDal: IEntityRepository<Customer>
   {
       public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
       {
           throw new NotImplementedException();
       }

       public Customer Get(Expression<Func<Customer, bool>> filter)
       {
           throw new NotImplementedException();
       }

       public void Add(Customer entity)
       {
           throw new NotImplementedException();
       }

       public void Update(Customer entity)
       {
           throw new NotImplementedException();
       }

       public void Delete(Customer entity)
       {
           throw new NotImplementedException();
       }
   }
}
