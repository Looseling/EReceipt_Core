namespace EReceipt.Core.Dto;

public class TransactionDto
{
    public string? Id { get; set; }
    public double? Amount { get; set; }
    public string? Recipient { get; set; }
    public DateTime? Date { get; set; }
    public StoreReceiptDto? StoreReceipt { get; set; }
    public string Sender { get; set; }
    public string SenderAccount { get; set; }
    public string RecipientAccount { get; set; }
    public TransType TransactionType { get; set; }
    
}

public enum TransType{
    Expense,
    Income
} 