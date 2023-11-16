using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace API.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Price { get; set; }
        public double DiscountPercentage { get; set; }
        public double Rating { get; set; }
        public int QuantityInStock { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string Thumbnail { get; set; }
        [NotMapped]
        public string[] Images { get; set; }

        public string ImageJson
        {
            get => JsonConvert.SerializeObject(Images);
            set => Images = JsonConvert.DeserializeObject<string[]>(value);
        }
    }
}