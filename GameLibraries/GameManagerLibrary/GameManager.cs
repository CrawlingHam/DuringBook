
using MenuManagerLibrary;
namespace GameManagerLibrary;

public class Game
{
    public void Start()
    {
        MenuUpdater newUpdater = new MenuUpdater(); // Instantiate a new menu
        newUpdater.UpdateMenu(); // Run the menu
    }
}
