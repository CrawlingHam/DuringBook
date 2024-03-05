/*
    >> Definitions <<

====//=> Console.ReadKey() - Obtains the next character or function key pressed by the user and 
    returns an object that describes the ConsoleKey constant and Unicode character
    Variants: 
        Readkey() - The pressed key is displayed in the console window.
        Readkey(bool intercept) - The pressed key is optionally displayed in the console window.

====//=> ConsoleKeyInfo - Describes the console key that was pressed, including the character 
    represented by the console key and the state of the SHIFT, ALT, and CTRL modifier keys. 
    The ConsoleKeyInfo object describes the ConsoleKey constant and Unicode character, if any, 
    that correspond to the pressed console key.
    Examples: 
    - Key: A        - Unicode character 65
    - Key: Escape   - Unicode character 27
    - Key: Spacebar - Unicode character 32

    The ConsoleKeyInfo object Also describes, in a bitwise combination of ConsoleModifiers values, 
    whether one or more SHIFT, ALT, or CTRL modifier keys was pressed simultaneously with the console key.

====//=> ConsoleKey - Specifies the standard keys on a console. See all keys: https://learn.microsoft.com/en-us/dotnet/api/system.consolekey?view=net-8.0

====//=> ConsoleModifiers - Represents the SHIFT, ALT, and CTRL modifier keys on a keyboard. No 
    distinction is made between the left or right SHIFT, ALT, and CTRL keys.



====//=> ConsoleColor. - Specifies constants that define foreground and background colors for the console.
    See all ConsoleColor(s) - https://learn.microsoft.com/en-us/dotnet/api/system.consolecolor?view=net-8.0

====//=> Console.ForegroundColor() -  A ConsoleColor that gets or sets the foreground color of the console. That is, 
    the color of each displayed character. ForegroundColor must be a valid member of ConsoleColor. The default is gray.



====//=> Console.BackgroundColor() - A ConsoleColor that gets or sets the background color of the console. That is, 
    the color that appears behind each character. BackgroundColor must be a valid member of ConsoleColor. The default is black.


====//=> Console.ResetColor() - Sets the foreground and background console colors to their defaults.


====//=>

====//=>

*/


using System;
using static System.Console;
using System.Text;
using System.Collections.Generic;

namespace MenuSelectionUI
{
    class Game
    {
        // Make ConsoleKeyInfo available to all methods in this class
        private ConsoleKeyInfo Input;

        public void Start()
        {
            // Initialise prompt and options
            string prompt = "Welcome. Choose one of the following";
            string[] options = new string[] {"Start", "Help", "About", "Quit"};
            Menu newMenu = new Menu(prompt, options);
            newMenu.DisplayOptions();

            // Later: implement wait time. 
            // print the line below first, then seconds after load mainMenu
            WriteLine("The game is starting....");
            Input = ReadKey(true);

            // Call End method
            End();
        }
        // End game if user presses ESCAPE (Esc) key
        public void End()
        {
            bool condition = true;
            while (condition)
            {
                WriteLine("Press Escape key (Esc) to exit.");
                Input = ReadKey(true);

                if (Input.Key == ConsoleKey.Escape)
                {
                    Write("Game terminating.....");
                    condition = false;
                }
                else
                {
                    WriteLine("Press Escape key (Esc) to exit.");
                }                
            }
        }
    }
}


/*
if (input.Key == ConsoleKey.Enter)
            {
                WriteLine("You pressed the ENTER Key");
            }
            else if (input.Key == ConsoleKey.UpArrow)
            {
                WriteLine("You pressed the Up Arrow Key");
            }
            else if (input.Key == ConsoleKey.DownArrow)
            {
                WriteLine("You pressed the Down Arrow Key");
            }   
            else
            {
                WriteLine("You pressed another key");
            }
*/