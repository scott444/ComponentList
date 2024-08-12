using ComponentTool.Import;

namespace ComponentTool.Test;

public static class ExampleDataGenerator
{
    public static List<LineItem> GenerateData(int rows)
    {
        var data = new List<LineItem>();
        var random = new Random();
        for (var i = 0; i < rows; i++)
        {
            data.Add(new LineItem
            {
                LineNumber = i + 1,
                Quantity = random.Next(1, 100),
                PartNumber = $"Part-{i + 1}",
                Description = $"Description-{i + 1}",
                UnitPrice = random.Next(1, 1000),
                ExtendedPrice = random.Next(1, 1000)
            });
        }
        return data;
    }
}