using CsvHelper;
using System.Globalization;

namespace ComponentTool;

public static class ListImporter
{
    public static List<LineItem> ImportCsv(string path)
    {
        if (!File.Exists(path))
            throw new InvalidOperationException("File not found");

        using var reader = new StreamReader(path);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        csv.Context.RegisterClassMap<LineItemMap>();
        var records = csv.GetRecords<LineItem>();
        return records.ToList();
    }
}
