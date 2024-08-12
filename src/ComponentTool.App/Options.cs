using CommandLine;

namespace ComponentTool.App;
internal class Options
{
    [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
    public bool Verbose { get; set; }
}
