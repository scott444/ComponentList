using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using System.Globalization;

namespace ComponentTool;

public sealed class LineItemMap : ClassMap<LineItem>
{
    public LineItemMap()
    {
        AutoMap(CultureInfo.InvariantCulture);
        Map(m => m.LineNumber).Name("Item", "LID");
        Map(m => m.SubitemNumber).Name("Sub", "Subitem");
        Map(m => m.Quantity).Name("Quantity", "Qty");
        Map(m => m.PartNumber).Name("PartNumber", "Part Number", "Nomenclature", "Model", "Model Number");
        Map(m => m.Description).Name("Description");
        Map(m => m.UnitPrice).Name("Unit", "Unit Price", "UnitPrice").TypeConverter<CurrencyConverter>();
        Map(m => m.ExtendedPrice).Name("Ext", "Extended", "Extended Price", "ExtendedPrice").TypeConverter<CurrencyConverter>();
    }
}

internal class CurrencyConverter : DefaultTypeConverter
{
    public override object ConvertFromString(string? text, IReaderRow row, MemberMapData memberMapData)
    {
        if (decimal.TryParse(text?.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"), out decimal result))
        {
            return result;
        }
        return default(decimal);
    }
}