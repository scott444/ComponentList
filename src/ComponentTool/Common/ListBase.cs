namespace ComponentTool.Common;

// https://stackoverflow.com/questions/17651424/bill-of-materials-database-model
public abstract class ListBase
{
    // PK,FK
    public string ParentPartNumber { get; set; } = string.Empty;
    // PK,FK
    public string ChildPartNumber { get; set; } = string.Empty;
    public int Quantity { get; set; }
}