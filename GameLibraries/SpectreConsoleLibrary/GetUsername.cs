using Spectre.Console;
namespace SpectreConsoleLibrary;
public class GetUser
{
    public static string UserName()
    {
        return AskUserName();
    }
 
    private static string AskUserName()
    {
        /*  Prompts the user for a first name and makes sure that the given input is
            all letters and does not contain additional words after a space. */
        return AnsiConsole.Prompt(
            new TextPrompt<string>("Enter A [green]Username[/]: ")
                .PromptStyle("yellow") // Sets color of user input. 
                .ValidationErrorMessage("[underline red]Invalid Username.[/]")
                .Validate(Name => {
                    return Name switch {

                        // Conditions for content of name
                        _ when Name.Count(char.IsPunctuation) <= 0 => ValidationResult.Error("[red]Username must contain atleast 1 symbol.[/]"),
                        _ when Name.Count(char.IsNumber) <= 2 => ValidationResult.Error("[red]Username must contain 3 numbers.[/]"),

                        // Conditions for length of name
                        _ when Name.Length <= 2 => ValidationResult.Error("[red]Name must be at least 3 characters long.[/]"),
                        _ when Name.Length >= 11 => ValidationResult.Error("[red]Name must be shorter than 10 character.[/]"),

                        // Return an error if there is more than one word
                        _ when Name.IndexOf(' ') > 0 && Name.Substring(Name.IndexOf(' ') + 1).Any(c => char.IsLetterOrDigit(c)) =>
                            ValidationResult.Error("[red]Username Can Only be one word.[/]"),

                        // Return name if all conditions are met
                        _ => ValidationResult.Success(),
                    };
                }
            )
        );
    }
}