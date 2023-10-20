using EReceipt.Core.Persistence;
using EReceipt.Core.Dtos;

namespace EReceipt.Core
{
    public static class Program
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

            app.MapGet("/GetQRData/{id}", (string id) =>
            {
                //find by uid linq
                StoreReceiptDto? result = MockData.StoreReceipts.FirstOrDefault(x => x.Id == id);
                return result != null ? Results.Ok(result) : Results.NotFound();
            });

            app.Run();
        }
    }
}