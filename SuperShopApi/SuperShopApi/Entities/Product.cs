namespace SuperShopApi.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public Guid ImageId { get; set; }

        public DateTime? LastPurchase { get; set; }

        public DateTime? LastSale { get; set; }

        public bool IsAvailable { get; set; }

        public double Stock { get; set; }

        public User User { get; set; }

        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://localhost:44345/images/noimage.png"
            : $"https://localhost:44345/products/{ImageId}.jpg";
    }
}
