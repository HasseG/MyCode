using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace WeatherForecastAPI.Controller.V2
{
	[ApiController]
	[ApiVersion("2.0")]
	[Route("api/v{version:apiVersion}/[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		public readonly HttpClient _httpClient;
		public WeatherForecastController(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		[MapToApiVersion("2.0")]
		public async Task<IActionResult> GetWeather(int numOfDays, string unit)
		{
			string responseBody = "";
			if (numOfDays != 0)
			{
				using HttpResponseMessage responseOW = await _httpClient.GetAsync("https://api.stormglass.io/v2/weather/point?lat=58.7984&lng=17.8081&params=swellHeight,swellPeriod&key=e6ba8822-60fe-11ee-8d52-0242ac130002-e6ba88b8-60fe-11ee-8d52-0242ac130002");
				responseBody = await responseOW.Content.ReadAsStringAsync();

				int totalTimeStamps = numOfDays * 8;
				using HttpResponseMessage responseSG = await _httpClient.GetAsync($"http://api.openweathermap.org/data/2.5/forecast?lat=55.40367357865401&lon=10.379796176974024&units={unit}&cnt={totalTimeStamps}&appid=b2eb1817e794b2764020207d96717449");
				responseSG.EnsureSuccessStatusCode();
				responseBody += await responseSG.Content.ReadAsStringAsync();

				return Ok(Content(responseBody, "Application/json"));
			}
			else
			{
				return NoContent();
			}
		}
	}
}
