using Spectre.Console;

namespace Raylib_CSharp.Samples;

public static class SamplesMenu {

    /// <summary>
    /// Displays a menu and prompts the user to select a sample to run.
    /// </summary>
    /// <param name="samples">An array of ISample objects representing the available samples.</param>
    /// <returns>A string representing the user's selection.</returns>
    public static string DisplayMenu(ISample[] samples) {
        List<string> options = new List<string>();
        options.Add("[red]Exit[/]");
        options.Add("[yellow]All[/]");

        foreach (ISample sample in samples) {
            options.Add($"[green]{sample.GetType().Name}[/]");
        }

        SelectionPrompt<string> consolePrompt = new SelectionPrompt<string>().PageSize(10).MoreChoicesText("[grey](Move up and down to reveal more samples)[/]").AddChoices(options);
        AnsiConsole.Write(new FigletText("Raylib-CSharp\nSamples").Color(Color.Purple).Justify(Justify.Center));
        AnsiConsole.Write(new Rule("[grey]Select a sample to run[/]").Centered());

        return Markup.Remove(AnsiConsole.Prompt(consolePrompt));
    }
}