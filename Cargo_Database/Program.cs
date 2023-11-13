﻿using Cargo_Database.Contexts;
using Cargo_Database.Repositorys;
using Cargo_Database.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Cargo_Database
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddDbContext<DataContext>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\skola\Databas\Cargo_Database\Cargo_Database\Contexts\CargoDb.mdf;Integrated Security=True;Connect Timeout=30"));
                    services.AddScoped<MenuService>();
                    services.AddScoped<VesselRepo>();
                    services.AddScoped<CargoRepo>();
                    services.AddScoped<CisternMeasureRepo>();
                    services.AddScoped<CisternRepo>();
                    services.AddScoped<VesselService>();
                })
                .Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var menuService = services.GetRequiredService<MenuService>();

                await menuService.MenuServiceMenu();
            }

            await host.RunAsync();
        }
    }
}