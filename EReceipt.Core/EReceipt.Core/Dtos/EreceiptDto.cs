namespace EReceipt.Core.Dtos;

public class StoreReceiptDto
{
    public Guid? Id { get; set; }
    public string? StoreName { get; set; }
    public Dictionary<string, double>? Items { get; set; }
    public DateTime? Date { get; set; }
    public double? Total { get; set; }
    public double? Tax { get; set; }
}
