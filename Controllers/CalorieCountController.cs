using System;
using Microsoft.AspNetCore.Mvc;
using TopBodBackend.Models;
using TopBodBackend.Services;

namespace TopBodBackend.Controllers;


[ApiController]
[Route("[controller]")]
public class CalorieCountController : ControllerBase
{
    private readonly ICalorieNinjasService _calorieNinjasService;
    private readonly IHttpClientFactory _httpFactory;

    public CalorieCountController(
        ICalorieNinjasService calorieNinjasService,
        IHttpClientFactory httpFactory
        )
    {
        _calorieNinjasService = calorieNinjasService;
        _httpFactory = httpFactory;
    }

    [HttpGet(Name = "GetNutritionDetails")]
    public IActionResult GetNutritionAsync(string query)
    {
        var nutrition = _calorieNinjasService.GetNutritionDetails(query);
        return Ok(nutrition);
    }

}

