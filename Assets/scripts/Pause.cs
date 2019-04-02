using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Brings up pause menu when the "key" KeyCode
// is pressed.

public class Pause : MonoBehaviour
{
    public bool paused;
    public KeyCode key;
    public GameObject pauseMenu;


    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            if (paused)
            {
                // Resume
                paused = false;
                pauseMenu.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                Time.timeScale = 1f;
            }
            else
            {
                // Pause
                paused = true;
                pauseMenu.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                Time.timeScale = 0f;
            }
        }
    }
}
