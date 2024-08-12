using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace ComponentTool.Import;

public static class ListImporter
{
    public static List<T> ImportCsv<T, TMap>(string path) where T : ILineItem where TMap : ClassMap<T>
    {
        if (!File.Exists(path))
            throw new InvalidOperationException("File not found");

        using var reader = new StreamReader(path);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        csv.Context.RegisterClassMap<TMap>();
        var records = csv.GetRecords<T>();
        return records.ToList();
    }
}
