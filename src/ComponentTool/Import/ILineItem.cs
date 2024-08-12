namespace ComponentTool.Import;

public interface ILineItem
{
    int LineNumber { get; set; }
    int Quantity { get; set; }
    string? Description { get; set; }
    string? PartNumber { get; set; }
    decimal UnitPrice { get; set; }
}