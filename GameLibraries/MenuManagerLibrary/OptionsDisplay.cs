using static System.Console;
namespace MenuManagerLibrary;

public partial class Display
{
    public void DisplayOptions( string[] options, int selectedIndex )
    {
        for ( int i = 0; i < options.Length; i++ )
        {
            string currentOption = options[i]; // Keeps track of the current option
            string prefix;

             if (i == selectedIndex)
            {
                prefix = "➜";
                ForegroundColor = ConsoleColor.Black;
                BackgroundColor = ConsoleColor.White;
                
            }
            // If the current index ISN'T the selected index
            // Initialize prefix to one space and reset the colors
            else
            {
                prefix = " ";
                ResetColor();
            }
            WriteLine($"{prefix} << {currentOption} >>");
            Console.ResetColor();
        }
    }
}