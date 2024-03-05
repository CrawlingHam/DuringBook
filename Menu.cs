using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace MenuSelectionUI
{
    class Menu
    {
        private int selectedIndex; // Global variable for tracking the selected index
        private string[] Options;  // Global variable for available options to the user
        private string Prompt;     // Global variable for displaying a prompt to the user
    
        public Menu(string prompt, string[] options)
        {
            Options = options;
            Prompt = prompt;
            selectedIndex = 0;
        }
        // Displays options to the user
        private void DisplayOptions()
        {
            // Firstly, print the prompt
            WriteLine(Prompt);

            // Iterate through the options, printing each option out 
            for (int i = 0; i < Options.Length; i++)
            {
                // Define the current option that is being hovered over
                string currentOption = Options[i];
                string prefix;
                // If the current index is the selected index:
                // Initialize prefix to an asterisk and-
                // Invert foreground and background colors 
                if (i == selectedIndex)
                {
                    prefix = "*";
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
                  
            }
            // Reset color after options are printed
            Console.ResetColor();
        }

        public int Run()
        {
            ConsoleKey keyPressed;
            
            // Keep loop running as long as the Enter key isn't pressed
            do
            {
                // Clear the console and display options to user
                Clear();
                DisplayOptions();

                // Store the key pressed by the user 
                ConsoleKeyInfo keyInfo = ReadKey( true );
                keyPressed = keyInfo.Key;

                // Change selectedIndex depending on if down arrow or up arrow is pressed
                // Make sure the selectedIndex is not the first index before moving it up
                // Make sure the selectedIndex is not the last index before moving it down
                // Wrap around array if out of bounds
                if ( keyPressed == ConsoleKey.UpArrow )
                {
                    selectedIndex--;
                    if ( selectedIndex == -1 )
                    {
                        selectedIndex = Options.Length - 1;
                    }
                }
                else if ( keyPressed == ConsoleKey.DownArrow )
                {
                    selectedIndex++;
                    if ( selectedIndex == Options.Length )
                    {
                        selectedIndex = 0;
                    }
                }
            } while ( keyPressed != ConsoleKey.Enter );

            return selectedIndex;
        }
    }
}