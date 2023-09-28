using System;
using Microsoft.AspNetCore.Mvc;
using TopBodBackend.Models;

namespace TopBodBackend.Controllers;


[ApiController]
[Route("[controller")]
public class CalorieCountController : ControllerBase
{
    private readonly IHttpClientFactory _httpFactory;
    public CalorieCountController(
        IHttpClientFactory httpFactory
        )
    {
        _httpFactory = httpFactory;
    }

    [HttpGet(Name = "GetNutritionDetails")]
    public async void GetNutritionAsync()
    {
        Console.WriteLine("response goes here");
    }

}

