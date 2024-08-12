namespace ComponentTool.Common;

public abstract class PartBase
{
    // PK

    public string PartNumber { get; set; } = string.Empty;
    public string? Description { get; set; }
}
