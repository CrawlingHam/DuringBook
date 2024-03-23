using static System.Console;
namespace MenuManagerLibrary;

public class Menu
{
    Display newDisplay = new Display(); // Instantiate a new display
    public void Run()
    {
        newDisplay.DisplayAbout(); // Display About logo
        newDisplay.DisplayPrompt(); // Display prompt message
    }
}
