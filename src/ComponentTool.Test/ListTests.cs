using ComponentTool.Common;
using ComponentTool.Import;

namespace ComponentTool.Test;

public class ListTests
{
    [Fact]
    public void CompareListTest()
    {
        var list1 = ExampleDataGenerator.GenerateData(10);
        var list2 = new List<LineItem>(list1);

        // modify list2
        list2[1].Description = "Modified Description";
        list2[3].Quantity = 5;
        list2[5].PartNumber = "Modified Part Number";
        list2.RemoveAt(7);
        list2.Add(new LineItem { LineNumber = 99, Quantity = 1, PartNumber = "New Part" });

        ListComparison.CompareLists(list1, list2);

        // TODO: Assert the results
    }
}