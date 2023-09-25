using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;
using WeatherForecast.Models;
using WeatherForecast.Models.DTO;

namespace WeatherForecast.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly HttpClient _client;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
			_client = new HttpClient();
		}

		public async Task<IActionResult> Index()
		{
			using HttpResponseMessage response = await _client.GetAsync("https://localhost:7207/GetWeather");
			response.EnsureSuccessStatusCode();
			string responseBody = await response.Content.ReadAsStringAsync();

			Console.WriteLine(responseBody);
				
			Root forecast = JsonSerializer.Deserialize<Root>(responseBody)!;

			ViewData["Weather"] = forecast.weather;
			ViewData["IconUrl"] = $"https://openweathermap.org/img/wn/{forecast.weather.First().icon}.png";

			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}