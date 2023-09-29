using System;
using System.Text.Json.Serialization;

namespace TopBodBackend.Models
{
	public class CalorieNinjasResponse
	{
		[JsonPropertyName("items")]
		public List<Food> Nutrition { get; set; }
	}
}

