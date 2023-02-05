using kipho.api.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kipho.api.domain.Interfaces
{
    public interface IProductsServices
    {
        Task<Products> Get(Guid id);
        Task<IEnumerable<Products>> GetAll();
        Task<Products> Post(Products user);
        Task<Products> Put(Products user);
        Task<bool> Delete(Guid id);
    }
}
