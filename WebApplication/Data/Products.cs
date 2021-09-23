using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApplication.Data
{
    public class Products
    {
        [JsonPropertyName("product_id")]
        public string productId { get; set; }


        [JsonPropertyName("type")]
        public string productType { get; set; }

        [JsonPropertyName("name")]
        public string productName { get; set; }


        [JsonPropertyName("description")]
        public string productDescription { get; set; }


        [JsonPropertyName("price")]
        public string productPrice { get; set; }

        [JsonPropertyName("img")]
        public string productImage { get; set; }

    }
}
