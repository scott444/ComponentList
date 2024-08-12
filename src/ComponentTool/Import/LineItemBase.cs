namespace ComponentTool.Import;

public abstract class LineItemBase : ILineItem
{
    public int LineNumber { get; set; }
    public int Quantity { get; set; }
    public string? Description { get; set; }
    public string? PartNumber { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal ExtendedPrice { get; set; }
}
