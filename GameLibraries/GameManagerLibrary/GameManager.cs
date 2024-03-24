
using MenuManagerLibrary;
namespace GameManagerLibrary;

public class Game
{
    public void Start()
    {
        Menu newMenu = new Menu(); // Instantiate a new menu
        newMenu.Run(); // Run the menu
    }
}
