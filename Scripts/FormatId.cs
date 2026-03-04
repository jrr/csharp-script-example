#:project ../MyApp.Data/MyApp.Data.csproj

using MyApp.Data.Utils;

if (args.Length < 2)
{
    Console.WriteLine("Usage:");
    Console.WriteLine("  dotnet run Scripts/FormatId.cs format <id>");
    Console.WriteLine("  dotnet run Scripts/FormatId.cs parse <formatted-id>");
    return 1;
}

var command = args[0].ToLower();

switch (command)
{
    case "format":
        if (!int.TryParse(args[1], out var id))
        {
            Console.Error.WriteLine($"Invalid ID: {args[1]}");
            return 1;
        }
        Console.WriteLine(IdFormatter.Format(id));
        return 0;

    case "parse":
        Console.WriteLine(IdFormatter.Parse(args[1]));
        return 0;

    default:
        Console.Error.WriteLine($"Unknown command: {command}");
        return 1;
}
