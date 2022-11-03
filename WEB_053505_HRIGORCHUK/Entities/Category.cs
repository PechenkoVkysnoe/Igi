using System.Collections.Generic;

namespace WEB_053505_HRIGORCHUK.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Product> products { get; set; }
    }
}
