using System.Collections.Generic;

namespace MaraToDoApi.Models
{
    public class ShoppingList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Item> Items { get; set; }
        public Status Status { get; set; }
    }
}