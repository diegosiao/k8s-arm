using Kubernetes.Sbc.Ui.Web.Utility;
using Microsoft.Extensions.FileProviders;
using System;

namespace Kubernetes.Sbc.Ui.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder();

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddHttpClient();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // app.UseHttpsRedirection();

            Console.Write("Base Directory: ");
            Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
            Console.WriteLine(Env.SERVICE_ASIA_WEATHER);
            Console.WriteLine(Env.SERVICE_EUROPE_WEATHER);
            Console.WriteLine(Env.SERVICE_SOUTHAMERICA_WEATHER);

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
