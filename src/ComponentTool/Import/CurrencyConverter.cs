using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using System.Globalization;

namespace ComponentTool.Import;

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