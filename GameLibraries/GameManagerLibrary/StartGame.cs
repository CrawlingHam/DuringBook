using static System.Console;
using MenuManagerLibrary;
namespace GameManagerLibrary;
public partial class Game
{
    public static void StartGame()
    {
        Clear(); // Clear the console
        WriteLine("Game is starting....");

        Display display = new Display(); 
        string prompt = display.DisplayPrompt(); // Display the prompt logo and message

        // Allow user to return to main menu
        ConsoleKeyInfo keyInfo = ReadKey( true ); 
        ConsoleKey keyPressed = keyInfo.Key;
        if ( keyPressed == ConsoleKey.Escape )
        {
            Clear();
            WriteLine(prompt);
            Start();
        }
        
    }
}