using System;
using System.Text.Json.Serialization;

namespace TopBodBackend.Models
{
	public class Food
	{
		[JsonPropertyName("name")]
		public string FoodName { get; set; }
		[JsonPropertyName("calories")]
		public decimal Calories { get; set; }
        [JsonPropertyName("serving_size_g")]
        public decimal ServingSizeInGrams { get; set; }
        [JsonPropertyName("fat_total_g")]
        public decimal TotalFatInGrams { get; set; }
        [JsonPropertyName("protein_g")]
        public decimal Protein { get; set; }
        [JsonPropertyName("carbohydrates_total_g")]
        public decimal Carbohydrates { get; set; }
    }
}

