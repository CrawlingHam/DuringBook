/*     >>> File 'MenuUpdater.cs' Description <<<

This class 'MenuUpdater' updates the menu whenever the user presses the Up/Down Arrows. In order for this to work, an instance of the
class 'MenuProperties' where the properties are defined is initialized as a private field. The fields are then given values by the helper
function 'PropertyHandler' which uses out parameters to return the values of the properties to be used. 


At the same time, the class 'Display' in which the  methods that display the prompt and options to the user is also initalized as a private field.
This class is a partial class, meaning it contains shared methods across multiple files. Among these methods, 'DisplayOptions' and 
'DisplayPrompt' are called inside a do-while loop and given their respective parameters if required. The do-while loop continues to iterate
until the user selects an option by pressing the Enter key, whose information is detected and stored inside ConsoleKeyInfo, and then determined
the exact key using ConsoleKeyInfo.Key and storing it inside ConsoleKey. For instance if the ReadKey method detects a key press, like the UpArrow, 
the ConsoleKeyInfo struct stores information extracted from the key press event, which is extracted and stored inside the ConsoleKey enum using the 
Key method. Example: ConsoleKey = ConsoleKeyInfo.Key.


After determining which key was pressed, a set of if-else statements are used to update the menu depending on if the Up Arrow is pressed or the Down Arrow.
Since this can lead to an IndexOutOfRangeException if the user scrolls too far up or down, I used an additional if statement to check if the selected index,
which is the curent option being hovered over, is less than the first index in the list, in which case set the selected index to the last index in the list.
If instead the selected index is bigger than the last index then set it back to the first index. After each iteration, the console is cleared, and the options are
displayed again, but this time the current option being hovered over will be at a different index. By default the current option being hovered over is at index 0, 
so if the user presses the Down Arrow, the next iteration's current option will be at index 1 and so on. This ensures smoother navigation where the user can
tell which option is the current selected option at all times.

 - Path to class 'MenuProperties' --> GameLibraries/MenuManagerLibrary/MenuProperties.cs
 - Path to class 'Display'        --> GameLibraries/MenuManagerLibrary/Display
  
  This class and it's methods are referenced in GameManager.cs
*/
