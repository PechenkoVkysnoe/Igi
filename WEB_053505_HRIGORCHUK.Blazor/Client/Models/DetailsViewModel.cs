using System.Text.Json.Serialization;

namespace WEB_053505_HRIGORCHUK.Blazor.Client.Models
{
    public class DetailsViewModel
    {
        [JsonPropertyName("productName")]
        public string ProductName { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("price")]
        public int Price { get; set; }
        [JsonPropertyName("image")]
        public string Image { get; set; }
    }
}
