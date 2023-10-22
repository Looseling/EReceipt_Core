using EReceipt.Core.Dto;

namespace EReceipt.Core.Persistence;

internal static class MockData
{
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
            Date = DateTime.Now.AddDays(-10),
            Sender = "Mike Tyson",
            SenderAccount = "7760717544",
            RecipientAccount = "3059833666",
            TransactionType = TransType.Expense
        },
        new TransactionDto
        {
        Id = "32E36939-C26B-4625-A06A-D9CB44FA9900",
        Amount = 10.96,
        Recipient = "Zabka",
        StoreReceipt = new StoreReceiptDto
        {
            Id = "42336939-C26B-4625-A06A-D9CB44FA9342",
            Recipient = "Walmart",
            Items = new Dictionary<string, double>
            {
                {"Avocado", 2.99},
                {"Almond Milk", 1.99},
                {"Cheese", 2.99},
                {"Tomato", 3.99}
            },
            Date = DateTime.Now.AddDays(-6),
            Total = 11.96,
            Tax = 1.3
        },
        Date = DateTime.Now.AddDays(-6),
        Sender = "Mike Tyson",
            SenderAccount = "5856007905",
            RecipientAccount = "7760717544",
            TransactionType = TransType.Expense
        },
        new TransactionDto
        {
            Id = "79A15412-B12D-4820-B25C-7A3B01A12345",
            Amount = 20.50,
            Recipient = "Target",
            StoreReceipt = new StoreReceiptDto
            {
                Id = "11CD7856-59A8-4ACD-BE28-4A7C01B45678",
                Recipient = "Target",
                Items = new Dictionary<string, double>
                {
                    {"Shampoo", 7.5},
                    {"Soap", 2.0},
                    {"Towel", 10.0}
                },
                Date = DateTime.Now.AddDays(-8),
                Total = 20.50,
                Tax = 2.2
            },
            Date = DateTime.Now.AddDays(-8),
            Sender = "Mike Tyson",
            SenderAccount = "7103058498",
            RecipientAccount = "8674956794",
            TransactionType = TransType.Expense
        },
        new TransactionDto
        {
        Id = "85e7c84e-18bb-463f-9775-cf7be5085a9d",
        Amount = 20.50,
        Recipient = "Auchan",
        StoreReceipt = new StoreReceiptDto
        {
            Id = "tr47c84e-18bb-463f-9775-cf7be5085t54",
            Recipient = "Target",
            Items = new Dictionary<string, double>
            {
                {"Cereal", 4.99},
                {"Toothpaste", 2.49},
                {"Shampoo", 7.99},
                {"Soap", 4.99}
            },
            Date = DateTime.Now.AddDays(-15),
            Total = 20.50,
            Tax = 2.0
        },
        Date = DateTime.Now.AddDays(-15),
            Sender = "Mike Tyson",
            SenderAccount = "5161507114",
            RecipientAccount = "6821156889",
            TransactionType = TransType.Expense
        },
        new TransactionDto
        {
            Id = "rew36142-C26B-4625-A06A-D9CB44FA9421",
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
            Date = DateTime.Now,
            Total = 10.96,
            Tax = 1.3
        },
            Date = DateTime.Now.AddDays(-24),
            Sender = "Mike Tyson",
            SenderAccount = "1124311483",
            RecipientAccount = "7539792669",
            TransactionType = TransType.Expense
        },
        new TransactionDto
        {
            Id = "pyp66A92-1AFB-4C66-A1CE-2EFEECD4004r",
            Amount = 109.9,
            Recipient = "Target",
            StoreReceipt =   new StoreReceiptDto
        {
            Id = "fd93DCCB-17AF-4566-9FC6-5F015669BC0s",
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
            Date = DateTime.Now.AddDays(-25),
            Sender = "Mike Tyson",
            SenderAccount = "4253473510",
            RecipientAccount = "3460308888",
            TransactionType = TransType.Expense
        },
        new TransactionDto
        {
            Id = "DC54B31F-74B7-4E6A-AD9F-8CA07B2857F4",
            Amount = 61.88,
            Recipient = "Costco",
            StoreReceipt =  new StoreReceiptDto
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
             Date = DateTime.Now.AddDays(-26),
            Sender = "Mike Tyson",
            SenderAccount = "8046319554",
            RecipientAccount = "3353128014",
            TransactionType = TransType.Expense
        },
        new TransactionDto
        {
            Id = "A01C8373-6B19-416D-BC97-593E9B5C5A05",
            Amount = 27.96,
            Recipient = "Lidl",
            StoreReceipt =   new StoreReceiptDto
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
             Date = DateTime.Now.AddDays(-27),
            Sender = "Mike Tyson",
            SenderAccount = "89034576034",
            RecipientAccount = "5476304589",
            TransactionType = TransType.Expense
        },
        new TransactionDto
        {
            Id = "5B9B4756-F415-413F-9E42-AA45CF47ED6D",
            Amount = 26.96,
            Recipient = "Whole Foods",
            StoreReceipt =  new StoreReceiptDto
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
        },
            Date = DateTime.Now.AddDays(-28),
            Sender = "Mike Tyson",
            SenderAccount = "4253473510",
            RecipientAccount = "9702893476",
            TransactionType = TransType.Expense
        }
    };
}