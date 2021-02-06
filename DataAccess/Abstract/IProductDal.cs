using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Interface metodları default public tir
    public interface IProductDal : IEntityRepository<Product>
    {
       
    }
}
//Code Refactoring -- kodun iyileştirilmesi