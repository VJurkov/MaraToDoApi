using System.Collections.Generic;
using System.Threading.Tasks;
using MaraToDoApi.Models;

namespace MaraToDoApi.Services
{
    public interface IItemService
    {
        Task<Item> GetOne(int id);
        Task<IEnumerable<Item>> GetAll();
        Task<Item> Delete(int id);
        Task<Item> Update(Item updatedItem);
        Task<Item> Add(Item item);

    }
}