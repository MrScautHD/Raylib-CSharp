using Raylib_CSharp.Samples;
using Raylib_CSharp.Samples.Core;
using Spectre.Console;

ISample[] samples = [
    new BasicWindow(),
    new CustomLogger(),
    new Pong(),
    new SpinningAroundADiamond()
];

string selection = args.Length == 0 ? SamplesMenu.DisplayMenu(samples) : args[0];

switch (selection) {
    case "Exit":
        Exit();
        break;

    case "All":
        RunAll(samples);
        break;

    default:
        Run(selection, samples);
        break;
}

return;

void Exit() {
    AnsiConsole.MarkupLine("Goodbye!");
    Thread.Sleep(1000); // wait a bit for the user to read the message
    Environment.Exit(0);
}

void RunAll(IEnumerable<ISample> samplesToRun) {
    foreach (ISample sample in samplesToRun) {
        using (sample) {
            AnsiConsole.MarkupLine($"Running [bold]{sample.GetType().Name}[/]");
            Thread.Sleep(1000); // wait a bit for the user to read the message
            sample.Run();
        }
    }
}

void Run(string selectionToRun, IEnumerable<ISample> samplesToRun) {
    ISample? sample = samplesToRun.FirstOrDefault(s => s.GetType().Name.Equals(selectionToRun, StringComparison.OrdinalIgnoreCase));

    if (sample == null) {
        AnsiConsole.MarkupLine($"[red]Sample not found: {selectionToRun}...[/]");
        Thread.Sleep(1000); // wait a bit for the user to read the message
        return;
    }

    using (sample) {
        AnsiConsole.MarkupLine($"Running [bold]{sample.GetType().Name}[/]");
        Thread.Sleep(1000); // wait a bit for the user to read the message
        sample.Run();
    }
}