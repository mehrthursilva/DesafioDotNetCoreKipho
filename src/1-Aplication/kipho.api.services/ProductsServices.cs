using kipho.api.domain.Entities;
using kipho.api.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kipho.api.services
{
    public class ProductsServices : IProductsServices
    {
        private IRepository<Products> _repository;

        public ProductsServices(IRepository<Products> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<Products> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<Products> GetbyBarcode(string id) 
        {
            return await _repository.SelectAsyncByCode(id);
        }

        public async Task<IEnumerable<Products>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<Products> Post(Products user)
        {
            return await _repository.InsertAsync(user);
        }

        public async Task<Products> Put(Products user)
        {
            return await _repository.UpdateAsync(user);
        }
    }
}
