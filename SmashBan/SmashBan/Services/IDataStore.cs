using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmashBan.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddItemAsync(T stage);
        Task<bool> UpdateItemAsync(T stage);
        Task<bool> DeleteItemAsync(string nom);
        Task<T> GetItemAsync(string nom);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}
