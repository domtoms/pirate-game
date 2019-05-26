using UnityEngine;
using NaughtyCharacter;

// Brings up pause menu when "key" is pressed.

public class Pause : MonoBehaviour
{
    public KeyCode key;
    public Animator pauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            if (pauseMenu.GetBool("open") == true)
            {
                resume();
            }
            else if (pauseMenu.GetBool("open") == false)
            {
                pause();
            }
        }
    }

    public void resume()
    {
        //paused = false;
        pauseMenu.SetBool("open", false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void pause()
    {
        //paused = true;
        pauseMenu.SetBool("open", true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
