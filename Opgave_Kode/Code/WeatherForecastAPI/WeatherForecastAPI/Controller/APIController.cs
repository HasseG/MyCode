using Microsoft.AspNetCore.Mvc;

namespace WeatherForecastAPI.Controller
{
	[Route("/GetWeather")]
	public class APIController : ControllerBase
	{
		public readonly HttpClient _httpClient;
		public APIController(HttpClient httpClient) 
		{
			_httpClient = httpClient;
		}
		public async Task<IActionResult> GetWeatherForecast()
		{
			using HttpResponseMessage response = await _httpClient.GetAsync("http://api.openweathermap.org/data/2.5/weather?q=Odense,dk&APPID=b2eb1817e794b2764020207d96717449");
			response.EnsureSuccessStatusCode();
			string responseBody = await response.Content.ReadAsStringAsync();

			return Content(responseBody, "Application/json");
		}
	}
}
