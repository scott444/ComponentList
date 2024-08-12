namespace ComponentTool;

public abstract class LineItemBase
{
    public int LineNumber { get; set; }
    public int Quantity { get; set; }
    public string? Description { get; set; }
    public string? PartNumber { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal ExtendedPrice { get; set; }
}
