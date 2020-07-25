namespace MaraToDoApi.Models
{
    public class Item
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public int ShoppingListId { get; set; }
        public Product Product { get; set; }
        public ShoppingList ShoppingList { get; set; }
    }
}