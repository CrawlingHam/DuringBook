using static System.Console;
using MenuManagerLibrary;
namespace GameManagerLibrary;
public partial class Game
{

    public static void Start()
    {
        StartHelper();
    }

    private static void StartHelper()
    {
        MenuUpdater menuUpdater = new MenuUpdater();
        int selectedIndex = menuUpdater.UpdateMenu(); // get the selected index

        switch ( selectedIndex )
        {
            case 0: // Start the game if 'Start' is selected
                StartGame();
                break;

            case 1: // Redirect to help page if 'Help' is selected
                Help();
                break;

            case 2: // Close the game if 'Quit' is selected
                Quit();
                break;
        }
    }
}
