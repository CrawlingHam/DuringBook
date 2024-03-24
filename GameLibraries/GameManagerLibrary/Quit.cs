using System;
using static System.Console;
namespace GameManagerLibrary;

public partial class Game
{
    public static void Quit()
    {
        Clear();
        WriteLine("Quitting game.......");
        Environment.Exit(0);
    }
}