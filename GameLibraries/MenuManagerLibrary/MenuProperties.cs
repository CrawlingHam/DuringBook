namespace MenuManagerLibrary;
public class MenuProperties
{
    // Private fields
    private string[] options = []; 
    private string prompt = "";
    private int selectedIndex;

    // Public properties
    public string[] Options
    {
        get => options;
        set => options = value;
    }
    public string Prompt
    {
        get => prompt;
        set => prompt = value;
    }
    public int SelectedIndex
    {
        get => selectedIndex;
        set => selectedIndex = value;
    }
}