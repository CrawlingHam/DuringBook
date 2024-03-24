using static System.Console;
using MenuManagerLibrary;
namespace GameManagerLibrary;
public partial class Game
{
    public static void Help()
    {
        Clear();
        HelpHelper();
    }

    private static void HelpHelper() // Displays the prompt logo and message to the user
    {
        Display display = new Display();
        WriteLine(display.DisplayAbout());
        AboutInfo();

        // Allow user to return to main menu
        ConsoleKeyInfo keyInfo = ReadKey( true ); 
        ConsoleKey keyPressed = keyInfo.Key;
        if ( keyPressed == ConsoleKey.Escape )
        {
            Start();
        }
    }
}