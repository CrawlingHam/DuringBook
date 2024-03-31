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
                //ForegroundColor = ConsoleColor.Black;
                //BackgroundColor = ConsoleColor.White;
                
            }
            // If the current index ISN'T the selected index
            // Initialize prefix to one space and reset the colors
            else
            {
                prefix = " ";
                //ResetColor();
            }
            WriteLine($"{prefix} << {currentOption} >>");
            //Console.ResetColor();
        }
    }
}

/*     >>> File Description <<<
This file contains a public partial class 'Display' that allows us to split the 
definition of the class across multiple source files. The individual files that 
use this class contain methods of the class definition, and these methods are 
merged into a single class at compile time by the compiler. 

The public void method 'DisplayOptions' of class 'Display' takes a list of 
string options and a selected index. The loop checks if the current index is 
the selected index, and if it is then the option is printed with a 
prefix of '➜' and inverted colors to indicate that the option is the current-
one that is being hovered over. The rest of the options have normal colors.

Complication: There is currently a minor bug where if one 'ResetColor' or 'Console.ResetColor' is
used, the console colors are not correctly displayed. When hovering over certain options,
'Start' and 'Help', the colors stretch across the entire terminal. Using both seems to have 
fixed it for the time being.

Related files: ./PromptDisplay.cs + ./AboutDisplay.cs
*/