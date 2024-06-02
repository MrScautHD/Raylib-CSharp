using Spectre.Console;

namespace Raylib_CSharp.Samples;

internal static class SamplesMenu {
    public static string DisplayMenu(ISample[] samples) {
        List<string> options = samples.Select(s => $"[green]{s.GetType().Name}[/]").ToList();
        options.Add("[yellow]All[/]");
        options.Add("[red]Exit[/]");

        SelectionPrompt<string> consolePrompt = new SelectionPrompt<string>()
                .PageSize(10)
                .MoreChoicesText("[grey](Move up and down to reveal more samples)[/]")
                .AddChoices(options)
            ;

        AnsiConsole.Write(new FigletText("Raylib-CSharp\nSamples").Color(Color.Purple).Justify(Justify.Center));
        AnsiConsole.Write(new Rule("[grey]Select a sample to run[/]").Centered());
        string selection = AnsiConsole.Prompt(consolePrompt);
        return Markup.Remove(selection);
    }
}