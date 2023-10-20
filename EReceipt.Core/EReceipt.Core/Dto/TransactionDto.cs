namespace EReceipt.Core.Dto;

public class TransactionDto
{
    public string? Id { get; set; }
    public double? Amount { get; set; }
    public string? Recipient { get; set; }
    public DateTime? Date { get; set; }
    public StoreReceiptDto? StoreReceipt { get; set; }
}