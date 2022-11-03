namespace WEB_053505_HRIGORCHUK.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public Category ProductCategory { get; set; }
    }
}
