using static System.Console;
using MenuManagerLibrary;
namespace GameManagerLibrary;

public class MenuUpdater
{
    private MenuProperties newMenuProperties = new MenuProperties(); // Initialize a MenuProperties instance
    private Display display = new Display(); // Initialize a Display instance

    public int UpdateMenu()
    {
        int selectedIndex = UpdateSelectedIndex(); // Return selected index
        return selectedIndex;
    }

    private int UpdateSelectedIndex()
    {
        PropertyHandler(out int selectedIndex, out string prompt, out string[] options); // Get property values
        ConsoleKey keyPressed;
        do
        {
            Clear(); // Clear the console
            WriteLine(prompt); // Display prompt 
            display.DisplayOptions( options, selectedIndex ); // Display the options
            ConsoleKeyInfo keyInfo = ReadKey( true ); // Read the key that is being pressed
            keyPressed = keyInfo.Key; // Store the key that was pressed

            if ( keyPressed == ConsoleKey.UpArrow )
            {
                selectedIndex--;
                if ( selectedIndex == - 1 )
                {
                    selectedIndex = options.Length - 1;
                }
            }
            else if ( keyPressed == ConsoleKey.DownArrow )
            {
                selectedIndex++;
                if ( selectedIndex == options.Length )
                {
                    selectedIndex = 0;
                }
            }
        } 
        while ( keyPressed != ConsoleKey.Enter );
        return selectedIndex;
    }
    
        // Set values to the properties and return them
    private void PropertyHandler(out int selectedIndex, out string prompt, out string[] options)
    {
        prompt = newMenuProperties.Prompt = display.DisplayPrompt();
        options = newMenuProperties.Options = new string[] { "Start", "About", "Quit" };
        selectedIndex = newMenuProperties.SelectedIndex = 0;
    }
}