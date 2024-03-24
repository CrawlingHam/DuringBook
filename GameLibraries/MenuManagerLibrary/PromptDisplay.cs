using static System.Console;
namespace MenuManagerLibrary;
public partial class Display
{
    public string DisplayPrompt()
    {
        string prompt = @"

          /$$$$$$                                    /$$ /$$                                                   
         /$$__  $$                                  | $$|__/                           /$$   /$$                        
        | $$  \__/  /$$$$$$   /$$$$$$  /$$  /$$  /$$| $$ /$$ /$$$$$$$   /$$$$$$       | $$  | $$
        | $$       /$$__  $$ |____  $$| $$ | $$ | $$| $$| $$| $$__  $$ /$$__  $$      | $$  | $$  /$$$$$$  /$$$$$$/$$$$
        | $$      | $$  \__/  /$$$$$$$| $$ | $$ | $$| $$| $$| $$  \ $$| $$  \ $$      | $$$$$$$$ |____  $$| $$_  $$_  $$
        | $$    $$| $$       /$$__  $$| $$ | $$ | $$| $$| $$| $$  | $$| $$  | $$      | $$__  $$  /$$$$$$$| $$ \ $$ \ $$
        |  $$$$$$/| $$      |  $$$$$$$|  $$$$$/$$$$/| $$| $$| $$  | $$|  $$$$$$$      | $$  | $$ /$$__  $$| $$ | $$ | $$
         \______/ |__/       \_______/ \_____/\___/ |__/|__/|__/  |__/ \____  $$      | $$  | $$|  $$$$$$$| $$ | $$ | $$
                                                                       /$$  \ $$      |__/  |__/ \_______/|__/ |__/ |__/           
                                                                      |  $$$$$$/                                        
                                                                       \______/                                         

                                    Welcome. What would you like to do?
                            - Contols - Up-Arrow and Down-Arrow to move between options
                            - To select - press Enter)
        ";
        return prompt;
    }
}