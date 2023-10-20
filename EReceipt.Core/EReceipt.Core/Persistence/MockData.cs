using EReceipt.Core.Dtos;

namespace EReceipt.Core.Persistence;

class MockData
{
    public static List<StoreReceiptDto> StoreReceipts { get; } = new()
    {
        new StoreReceiptDto
        {
            Id = Guid.NewGuid(),
            StoreName = "Walmart",
            Items = new Dictionary<string, double>
            {
                {"Milk", 2.99},
                {"Eggs", 1.99},
                {"Bread", 1.99},
                {"Cheese", 3.99}
            },
            Date = DateTime.Now,
            Total = 10.00,
            Tax = 0.50
        },
        new StoreReceiptDto
        {
            Id = Guid.NewGuid(),
            StoreName = "Target",
            Items = new Dictionary<string, double>
            {
                {"Meat", 24.99},
                {"Zubrowka", 40.99},
                {"Chips", 9.99},
            },
            Date = DateTime.Now,
            Total = 10.00,
            Tax = 0.50
        },
        new StoreReceiptDto
        {
            Id = Guid.NewGuid(),
            StoreName = "Costco",
            Items = new Dictionary<string, double>
            {
                {"Torilla Chips", 8.99},
                {"Salsa", 7.99},
                {"Sour Cream", 5.99},
                {"Cheese", 4.99}
            },
            Date = DateTime.Now,
            Total = 10.00,
            Tax = 0.50
        },
        new StoreReceiptDto
        {
            Id = Guid.NewGuid(),
            StoreName = "Safeway",
            Items = new Dictionary<string, double>
            {
                {"Sausage", 6.99},
                {"Buns", 4.99},
                {"Mustard", 7.99},
                {"Ketchup", 7.99}
            },
            Date = DateTime.Now,
            Total = 27.96,
            Tax = 0.50
        },
        new StoreReceiptDto
        {
            Id = Guid.NewGuid(),
            StoreName = "Whole Foods",
            Items = new Dictionary<string, double>
            {
                {"Piwo Harnas", 3.99},
                {"Piwo Zywiec", 3.99},
                {"Piwo Tyskie", 3.99},
                {"Piwo Okocim", 2.99}
            },
            Date = DateTime.Now,
            Total = 15.96,
            Tax = 1.92
        }
    };
}