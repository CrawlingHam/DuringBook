using System.Threading;
using static System.Console;
using MenuManagerLibrary;
namespace GameManagerLibrary;
public partial class Game
{
    public static void StartGame()
    {
        Clear(); // Clear the console
        WriteLine("Game is starting...."); // Add loading screen later
        Thread.Sleep(1500);
        Clear();

        OnStandBy();
    }
    private static void OnStandBy()
    {
        /* Allow user to return to main menu */
        Display display = new Display(); 
        string prompt = display.DisplayPrompt(); 
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