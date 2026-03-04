namespace MyApp.Data.Utils;

public static class IdFormatter
{
    private const string Prefix = "INV";

    /// <summary>
    /// Formats an integer ID for display.
    /// Example: 12345678 → "INV-1234-5678"
    /// </summary>
    public static string Format(int id)
    {
        var digits = id.ToString("D8");
        return $"{Prefix}-{digits[..4]}-{digits[4..]}";
    }

    /// <summary>
    /// Parses a formatted ID back to its integer value.
    /// Example: "INV-1234-5678" → 12345678
    /// </summary>
    public static int Parse(string formatted)
    {
        var stripped = formatted
            .Replace(Prefix + "-", "")
            .Replace("-", "");

        if (!int.TryParse(stripped, out var result))
        {
            throw new FormatException($"Invalid formatted ID: {formatted}");
        }

        return result;
    }
}
