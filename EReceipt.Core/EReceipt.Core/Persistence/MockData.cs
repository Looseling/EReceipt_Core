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
            Total = 10.96,
            Tax = 1.3
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
                {"Curry", 7.99},
                {"Rice", 5.99},
                {"Soda", 4.99},
                {"Water", 3.99},
                {"Milk", 2.99},
                {"Eggs", 1.99},
                {"Bread", 1.99},
                {"Cheese", 3.99}
            },
            Date = DateTime.Now,
            Total = 109.9,
            Tax = 13.2
        },
        new StoreReceiptDto
        {
            Id = Guid.NewGuid(),
            StoreName = "Costco",
            Items = new Dictionary<string, double>
            {
                {"Torilla Chips", 9.99},
                {"Salsa", 7.99},
                {"Sour Cream", 5.99},
                {"Cheese", 4.99},
                {"Ground Beef", 9.99},
                {"Tortillas", 3.99},
                {"Lettuce", 2.99},
                {"Tomatoes", 3.99},
                {"Onions", 2.99},
                {"Avocado", 1.99},
                {"Limes", 1.99},
                {"Cilantro", 1.99},
                {"Garlic", 2.99},
            },
            Date = DateTime.Now,
            Total = 61.88,
            Tax = 7.4
        },
        new StoreReceiptDto
        {
            Id = Guid.NewGuid(),
            StoreName = "Lidl",
            Items = new Dictionary<string, double>
            {
                {"Sausage", 6.99},
                {"Buns", 4.99},
                {"Mustard", 7.99},
                {"Ketchup", 7.99}
            },
            Date = DateTime.Now,
            Total = 27.96,
            Tax = 3.36
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
                {"Piwo Okocim", 2.99},
                {"Piwo Lech", 2.99},
                {"Piwo Zubr", 2.99},
                {"Piwo Warka", 2.99},
                {"Piwo Perla", 2.99},
            },
            Date = DateTime.Now,
            Total = 26.96,
            Tax = 3.2
        }
    };
}