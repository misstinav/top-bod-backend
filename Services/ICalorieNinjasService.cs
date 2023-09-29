using System;
using TopBodBackend.Models;

namespace TopBodBackend.Services
{
	public interface ICalorieNinjasService
	{
		List<NutritionDetails> GetNutritionDetails(string query);
	}
}

