using static System.Console;
namespace MenuManagerLibrary;
public partial class Display
{
    public void DisplayAbout()
    {
        WriteLine(@"
             ▄████████ ▀█████████▄   ▄██████▄  ███    █▄      ███     
            ███    ███   ███    ███ ███    ███ ███    ███ ▀█████████▄
            ███    ███   ███    ███ ███ ░  ███ ███    ███ ░  ▀███▀▀██
            ███    ███  ▄███▄▄▄██▀  ███    ███ ███  ░ ███     ███   ▀
          ▀███████████ ▀▀███▀▀▀██▄  ███    ███ ███    ███  ░  ███    ░
            ███    ███   ███    ██▄ ███ ░  ███ ███    ███     ███   ░  ░
            ███ ░  ███   ███    ███ ███    ███ ███ ░  ███     ███    ░
            ███    █▀  ▄█████████▀   ▀██████▀  ████████▀  ░  ▄████▀   
            ▒   ▒▒ ░▒░▒   ░ ▒░ ░ ▒ ▒  ░ ▒░ ░░   ▒  ▒░ ░░    ▒░ ▒ ░▒   ░
            ░ ░ ▒    ░    ░ ░ ░ ░ ▒   ░ ░ ░ ░   ░  ▒░ ▒  ▒░   ▒ ░▒░
            ░  ░ ░  ░    ░  ░ ░     ░  ░  ░   ▒  ░    ░    ▒ ░
            ░              ░            ░           ░        ░
        ");
    }
}