using System;
using System.Text.Json;
using Microsoft.Extensions.Options;
using TopBodBackend.Config;
using TopBodBackend.Models;

namespace TopBodBackend.Services
{
    public class CalorieNinjasService : ICalorieNinjasService
    {
        private CalorieNinjas _calorieNinjasConfig;
        private readonly IHttpClientFactory _httpFactory;

        public CalorieNinjasService(
            IOptions<CalorieNinjas> opts,
            IHttpClientFactory httpFactory)
        {
            _calorieNinjasConfig = opts.Value;
            _httpFactory = httpFactory;
        }

        public async Task<List<NutritionDetails>> GetNutritionDetails(string query)
        {
            string url = $"https://api.calorieninjas.com/v1/nutrition?query={query}";
            var nutritionDetails = new List<NutritionDetails>();
            var client = _httpFactory.CreateClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
            //issue is with extracting apiKey, GET works fine when key is hard-coded.
            request.Headers.Add("X-Api-Key", _calorieNinjasConfig.ApiKey);

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            //can add try/catch or conditional testing for good response other
            //than the line above
            var json = await response.Content.ReadAsStringAsync();
            var calorieNinjasResponse = JsonSerializer.
                Deserialize<CalorieNinjasResponse>(json);

            foreach (var foodItem in calorieNinjasResponse.Nutrition)
            {
                nutritionDetails.Add(new NutritionDetails
                {
                    FoodName = foodItem.FoodName,
                    Calories = foodItem.Calories,
                    ServingInGrams = foodItem.ServingSizeInGrams,
                    TotalCarbsInGrams = foodItem.Carbohydrates,
                    TotalProteinInGrams = foodItem.Protein,
                    TotalFatInGrams = foodItem.TotalFatInGrams
                });
            }

            return nutritionDetails;
        }
    }
}