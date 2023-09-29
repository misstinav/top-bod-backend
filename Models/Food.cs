﻿using System;
namespace TopBodBackend.Models
{
	public class Food
	{
		public int Id { get; set; }
		public string FoodName { get; set; }
		public decimal Calories { get; set; }
		public decimal ServingSizeInGrams { get; set; }
		public decimal TotalFatInGrams { get; set; }
		public decimal Protein { get; set; }
		public decimal Carbohydrates { get; set; }
	}
}

