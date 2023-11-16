namespace API.Entities
{
    public class Basket
    {
        public int Id { get; set; }
        public string BuyerId { get; set; }
        public List<BasketItem> Items { get; set; } = new();
        public void AddItems(Product product, int quantity)
        {
            if (Items.TrueForAll(i => i.ProductId != product.Id))
            {
                Items.Add(new BasketItem { Product = product, Quantity = quantity });
            }
            var item = Items.Find(i => i.ProductId == product.Id);
            if (item == null) return;
            item.Quantity += quantity;
        }

        public void RemoveItems(int productId, int quantity)
        {

            var item = Items.Find(i => i.ProductId == productId);
            if (item == null) return;
            item.Quantity -= quantity;
            if (item.Quantity <= 0) Items.Remove(item);
        }
    }
}