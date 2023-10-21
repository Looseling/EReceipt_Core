using EReceipt.Core.Dto;
using EReceipt.Core.Persistence;

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

            app.MapGet("/Transactions/{id}", (string id) =>
            {
                //find by uid linq
                TransactionDto? result = MockData.OldTransactions.FirstOrDefault(x => x.Id == id);
                if (result != null)
                {
                    result.Date = DateTime.Now;
                    return Results.Ok(result);
                }

                return Results.NotFound();
            });

            app.MapGet("/Transactions", () =>
            {


                return MockData.OldTransactions;
            });

            app.Run();
        }
    }
}