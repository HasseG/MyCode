using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using WeatherForecastAPI.Controller;

namespace WeatherForecastAPI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllers();

			builder.Services.AddApiVersioning(options =>
			{
				options.AssumeDefaultVersionWhenUnspecified = true;
				options.DefaultApiVersion = ApiVersion.Default;


				options.ApiVersionReader = ApiVersionReader.Combine
				(
					new QueryStringApiVersionReader("api-version"),
					new HeaderApiVersionReader("x-version"),
					new MediaTypeApiVersionReader("ver")
				);
			});

			builder.Services.AddVersionedApiExplorer(options =>
			{
				options.GroupNameFormat = "v'VVV";
				options.SubstituteApiVersionInUrl = true;
			});

			builder.Services.AddHttpClient();


			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}