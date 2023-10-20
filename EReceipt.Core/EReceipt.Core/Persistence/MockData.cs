using EReceipt.Core.Dto;

namespace EReceipt.Core.Persistence;

internal static class MockData
{
    public static List<StoreReceiptDto> StoreReceipts { get; } = new()
    {
        new StoreReceiptDto
        {
            Id = "14BD3112-26A1-45CF-8CB7-8AE190C6217C",
            Recipient = "Walmart",
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
            Id = "F693DCCB-17AF-4566-9FC6-5F015669BC0C",
            Recipient = "Target",
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
            Id = "11847105-9A9A-463A-A2BF-75560346D608",
            Recipient = "Costco",
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
            Id = "04734E4D-2166-44E6-A395-29D2EBEB9A06",
            Recipient = "Lidl",
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
            Id = "14F25F14-1F04-4ED2-A475-C82961EF15C0",
            Recipient = "Whole Foods",
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

    public static List<TransactionDto> Transactions { get; } = new()
    {
        new TransactionDto
        {
            Id = "49E36142-C26B-4625-A06A-D9CB44FA9562",
            Amount = 10.96,
            Recipient = "Walmart",
            StoreReceipt = StoreReceipts[0]
        },
        new TransactionDto
        {
            Id = "05266A92-1AFB-4C66-A1CE-2EFEECD40049",
            Amount = 109.9,
            Recipient = "Target",
            StoreReceipt = StoreReceipts[1]
        },
        new TransactionDto
        {
            Id = "DC54B31F-74B7-4E6A-AD9F-8CA07B2857F4",
            Amount = 61.88,
            Recipient = "Costco",
            StoreReceipt = StoreReceipts[2]
        },
        new TransactionDto
        {
            Id = "A01C8373-6B19-416D-BC97-593E9B5C5A05",
            Amount = 27.96,
            Recipient = "Lidl",
            StoreReceipt = StoreReceipts[3]
        },
        new TransactionDto
        {
            Id = "5B9B4756-F415-413F-9E42-AA45CF47ED6D",
            Amount = 26.96,
            Recipient = "Whole Foods",
            StoreReceipt = StoreReceipts[4]
        }
    };

    public static List<TransactionDto> OldTransactions { get; } = new()
    {
        new TransactionDto
        {
            Id = "49E36142-C26B-4625-A06A-D9CB44FA9562",
            Amount = 10.96,
            Recipient = "Walmart",
            StoreReceipt = new StoreReceiptDto
            {
                Id = "14BD3112-26A1-45CF-8CB7-8AE190C6217C",
                Recipient = "Walmart",
                Items = new Dictionary<string, double>
                {
                    {"Milk", 2.99},
                    {"Eggs", 1.99},
                    {"Bread", 1.99},
                    {"Cheese", 3.99}
                },
                Date = DateTime.Now.AddDays(-10),
                Total = 10.96,
                Tax = 1.3
            },
            Date = DateTime.Now.AddDays(-10)
        },
    };
}