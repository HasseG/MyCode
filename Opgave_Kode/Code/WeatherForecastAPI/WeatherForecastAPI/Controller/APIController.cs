using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

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
		public async Task<IActionResult> GetWeatherForecast(int numOfDays, string unit)
		{
			string responseBody = "";
			if (numOfDays != 0)
			{
				int totalTimeStamps = numOfDays * 8;
				using HttpResponseMessage response = await _httpClient.GetAsync($"http://api.openweathermap.org/data/2.5/forecast?lat=55.40367357865401&lon=10.379796176974024&units={unit}&cnt={totalTimeStamps}&appid=b2eb1817e794b2764020207d96717449");
				response.EnsureSuccessStatusCode();
				responseBody = await response.Content.ReadAsStringAsync();
			}
			return Content(responseBody, "Application/json");
		}
	}
}
