using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Organizacao.Models;

namespace Organizacao.Services
{
    public interface IDataStore<T> where T : ModelBase
    {
        Task<bool> AddAsync(T item);
        Task<bool> UpdateAsync(T item);
        Task<bool> DeleteAsync(string id);
        Task<T> GetAsync(string id);
        Task<IEnumerable<T>> GetsAsync(bool forceRefresh = false);
    }
}
