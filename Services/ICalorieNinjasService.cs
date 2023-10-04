using System;
using TopBodBackend.Models;

namespace TopBodBackend.Services
{
	public interface ICalorieNinjasService
	{
		Task<List<NutritionDetails>> GetNutritionDetails(string query);
	}
}

