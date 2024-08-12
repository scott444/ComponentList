using CommandLine;
using ComponentTool.App;

const string version = "1.0.0";
Console.WriteLine("Component Tool");
Console.WriteLine(version);

Parser.Default.ParseArguments<Options>(args)
                .WithParsed(RunOptions)
                .WithNotParsed(HandleParseError);

static void RunOptions(Options opts)
{
    if (opts.Verbose)
    {
        Console.WriteLine($"Verbose output enabled. Current Arguments: -v {opts.Verbose}");
        Console.WriteLine("Quick Start Example! App is in Verbose mode!");
    }
    else
    {
        Console.WriteLine($"Current Arguments: -v {opts.Verbose}");
        Console.WriteLine("Quick Start Example!");
    }
}

static void HandleParseError(IEnumerable<Error> errs)
{
    Console.WriteLine("Invalid arguments " + errs);
}