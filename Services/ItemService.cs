using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaraToDoApi.Db;
using MaraToDoApi.Models;
using Microsoft.EntityFrameworkCore;
namespace MaraToDoApi.Services
{
    public class ItemService : IItemService
    {
        private readonly MaraToDoContext _context;

        public ItemService(MaraToDoContext context)
        {
            _context = context;
        }

        public async Task<Item> Add(Item item)
        {
            _context.Items.Add(item);
            await _context.SaveChangesAsync();

            return item;
        }

        public async Task<Item> Delete(int id)
        {
            var item = await _context.Items.FindAsync(id);
            if (item == null)
            {
                return null;
            }

            _context.Items.Remove(item);
            await _context.SaveChangesAsync();
            return item;
        }

        //async oznacuje funkciju koja moze pauzirati
        public async Task<IEnumerable<Item>> GetAll()
        {
            return await _context.Items.ToListAsync();
        }

        public async Task<Item> GetOne(int id)
        {
            var item = await _context.Items.FindAsync(id);

            return item;
        }

        public async Task<Item> Update(Item updatedItem)
        {
            _context.Entry(updatedItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemExists(updatedItem.Id))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }

            return null;
        }

        private bool ItemExists(int id)
        {
            return _context.Items.Any(e => e.Id == id);
        }
    }
}