namespace GameManagerLibrary;
using MenuManagerLibrary;
using static System.Console;
public partial class Game
{
    public static void AboutInfo()
    {
        string about = AboutInfoHelper();
        WriteLine(about);
    }

    private static string AboutInfoHelper()
    {
        string about = @"
        
        Insert project info here.
        ";
        return about;
    }
}