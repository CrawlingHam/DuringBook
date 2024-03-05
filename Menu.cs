using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace MenuSelectionUI
{
    class Menu
    {
        // Initialize a variable for tracking the selected index,
        // a variable for availbale options and
        // a variable for displaying the prompt
        private int SelectedIndex;
        private string[] Options;  // Options: Play, About, Exit
        private string Prompt;     // Menu Title
        
        public Menu(string prompt, string[] options)
        {
            Options = options;
            Prompt = prompt;
            SelectedIndex = 0;
        }
        // Displays options to the user
        public void DisplayOptions()
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
                if (i == SelectedIndex)
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
    }
}