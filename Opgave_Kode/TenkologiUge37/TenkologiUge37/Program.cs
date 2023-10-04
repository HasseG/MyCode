namespace TenkologiUge37
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			var app = builder.Build();

			app.Run(async (HttpContext ctx) =>
			{
				string path = ctx.Request.Path;
				if (path == "/Home")
				{

					ctx.Response.StatusCode = 200;
					await ctx.Response.WriteAsync("Dis da home page");
				}
				else if (path == "/")
				{
					ctx.Response.Headers["Cotent-Type"] = "text/html";
					ctx.Response.Headers["MyHeader"] = "Hello World!";
					await ctx.Response.WriteAsync("<h2>This is HTML response");
				}
				else if (path == "/About")
				{
					ctx.Response.StatusCode = 200;
					await ctx.Response.WriteAsync("Dis da about page");
				}
				else if (path == "/Products")
				{
					ctx.Response.StatusCode = 200;
					await ctx.Response.WriteAsync("Dis da products page");
				}
				else
				{
					ctx.Response.StatusCode = 404;
					await ctx.Response.WriteAsync("Page not found");
				}
			}
				app.Run();
		}
	}
}