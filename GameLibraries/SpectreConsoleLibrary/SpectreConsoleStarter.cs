using System;
using static System.Console;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Threading;
using Spectre.Console;
namespace SpectreConsoleLibrary;
public class SpectreConsoleStarter
{
    public static void StartSpectreConsole()
    {
        Clear();
        SpectreHelper();
    }
    private static void SpectreHelper()
    {
        Console.WriteLine("Hello");
        //string userInput = AnsiConsole.Ask<string>("Enter Your [underline green]Name[/]: ").Replace(" ", "");
        //string userName = ReusableCode.Capitalize(userInput); // Custom method
        //AnsiConsole.MarkupLine($"Good Morning [yellow]{userName}[/].");
        
        string name = GetUser.UserName();
        //string capitalizedName = Capitalize.CapitalizeName(name);
        string ValidatedName = ValidateUserName(name);
        AnsiConsole.MarkupLine(ValidatedName);
    }
    private static string ValidateUserName(string name)
    {
        /*  Asks the user if they want to set their user name as their given name.
            Returns the name if the user says yes, otherwise lets them change their name. */
        while (true)
        {
            if (AskConfirmation(name))
            {
                AnsiConsole.MarkupLine("Setting User Name....");
                Thread.Sleep(1500);
                return name;
            }
            else
            {
                AnsiConsole.MarkupLine("Please Enter A User Name To Continue.");
                string newName = GetUser.UserName();
                name = newName;
            }
        }
    }
    private static bool AskConfirmation(string name)
    {
        /*  Returns true if user types 'y'
            Returns false if user types 'n'
            Reprompts if user types anything other than [y/n] */
        if (AnsiConsole.Confirm($"Set User Name as [yellow]{name}[/]?"))
        {
            return true;
        }
        return false;            
    }
}

/* Documentation for SpectreConsole: https://spectreconsole.net/quick-start  


[underline yellow] - Underlines the text and makes the foregroundColor red

[/] - Resets color and underline

.MarkupLine() - Similar to WriteLine()

.PromptStyle("yellow") - Sets color of user input. Whatever comes after ':'
    Example: Enter Your Name: Jack  ('Jack' gets a yellow foreground color)
                            ↑↑↑↑↑↑↑   
*/


/* the first optons: start, help, quit, were made by me, and the oters were used with libraries such as SpectreConsole
started this project around february of 2024 */
