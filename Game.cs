using System;
using static System.Console;
using System.Text;
using System.Collections.Generic;

namespace MenuSelectionUI
{
    class Game
    {
        // Privatize and globalize 
        private ConsoleKeyInfo Input;
        private string[] options;
        private Menu newMenu; 

        // Calls RunMenu method
        public void Start()
        {   
            RunMenu(); 
        }
        // Initializes prompt, options, a new menu, and calls the methods: StartGame, AboutInfo, QuitGame
        private void RunMenu()
        {
            string prompt = "Welcome"; // Initialise prompt and options
            options = new string[] {"Start", "About", "Quit"}; // List of program options
            newMenu = new Menu(prompt, options); // Initiate a new menu, passing the prompt and options as arguments
            int selectedIndex = newMenu.Run(); // Get the selected index 
            switch (selectedIndex) // Call different methods depending on the selected index
            {
                case 0:
                    StartGame();
                    break;
                case 1:
                    AboutInfo();
                    break;
                case 2:
                    QuitGame();
                    break;
            }
        }
        // Displays further options if user starts the game
        public void StartGame()
        {
            Clear();
            Write("Starting game");   
        }
        // Displays information about the game to the user
        public void AboutInfo()
        {
            Clear();
            Write("About");

            WriteLine("Press any key to return to the menu."); // Set up a specific key for returning to main menu
            ReadKey( true );
            RunMenu();
        }
        // End game if user presses ESCAPE (Esc) key
        public void QuitGame()
        {
            Clear();
            // Later: implement wait time. 
            //WriteLine("The game is starting....");
            WriteLine("Quitting game...");
            //Environment.Exit(0);
        }
    }
}