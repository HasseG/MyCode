using DI_Opgave.Models;
using System.Diagnostics.Metrics;

namespace DI_Opgave
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IMessage, Dummy>();
            builder.Services.AddScoped<IMessage, Dummy2>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            ////Middleware 1
            //app.Use(async (HttpContext ctx, RequestDelegate next) =>
            //{
            //    await ctx.Response.WriteAsync("Middleware 1 started\n\n");
            //    await next(ctx);
            //    await ctx.Response.WriteAsync("Middleware 1 finished\n\n");
            //});

            ////Middleware 2 
            //app.Use(async (ctx, next) =>
            //{
            //    await ctx.Response.WriteAsync("Middleware 2 calculating\n\n");
            //    int counter = 0;
            //    for (int i = 0; i < 1000; i++)
            //    {
            //        counter = counter += i += 21;
            //    }
            //    await ctx.Response.WriteAsync($"Middleware 2 calculating. Result = {counter}\n\n");
            //    await next(ctx);
            //    await ctx.Response.WriteAsync($"Middleware 2 finished\n\n");
            //});

            ////Middleware 3 termintaing 
            //app.Run(async (HttpContext ctx) =>
            //{
            //    await ctx.Response.WriteAsync("Terminating middleware 3\n\n");
            //});

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
        }
}
}