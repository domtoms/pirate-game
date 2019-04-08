using UnityEngine;

// Closes the application when "Quit()" is called.

public class CloseApplication : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }
}
