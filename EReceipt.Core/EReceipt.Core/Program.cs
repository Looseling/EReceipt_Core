

using EReceipt.Core.Persistence;
using EReceipt.Core.Dtos;

namespace EReceipt.Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

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

            var summaries = new[]
            {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

            app.MapGet("/weatherforecast", (HttpContext httpContext) =>
            {
                var forecast = Enumerable.Range(1, 5).Select(index =>
                    new WeatherForecast
                    {
                        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                        TemperatureC = Random.Shared.Next(-20, 55),
                        Summary = summaries[Random.Shared.Next(summaries.Length)]
                    })
                    .ToArray();
                return forecast;
            })
            .WithName("GetWeatherForecast")
            .WithOpenApi();

            app.MapGet("/GetQRData/{QRV:int}", (int QRV) =>
            {
                StoreReceiptDto result = null;
                
                switch (QRV)
                {
                    case 1:
                        result = MockData.StoreReceipts[0];
                        break;
                    case 2:
                        result = MockData.StoreReceipts[1];
                        break;
                    case 3:
                        result = MockData.StoreReceipts[2];
                        break;
                    case 4:
                        result = MockData.StoreReceipts[3];
                        break;
                    case 5:
                        result = MockData.StoreReceipts[4];
                        break;
                    default:
                        return null;
                }
                return result;
            });

            app.Run();
        }
    }
}