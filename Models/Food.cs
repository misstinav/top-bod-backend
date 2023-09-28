using System;
namespace TopBodBackend.Models
{
	public class Food
	{
		public int Id { get; set; }
		public string FoodName { get; set; }
		public int Calories { get; set; }
		public int ServingSizeInGrams { get; set; }
		public float TotalFatInGrams { get; set; }
		public float Protein { get; set; }
		public float Carbohydrates { get; set; }
	}
}

