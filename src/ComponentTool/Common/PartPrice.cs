namespace ComponentTool.Common;

public class PartPrice
{
    // PK,FK
    public string PartNumber { get; set; } = string.Empty;

    // PK
    public DateTime Date { get; set; }

    // PK,FK
    public string PriceBook { get; set; } = string.Empty;

    public decimal UnitPrice { get; set; }
}
