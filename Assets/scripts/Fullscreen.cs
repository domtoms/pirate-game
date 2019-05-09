using UnityEngine;
using UnityEngine.UI;

public class Fullscreen : MonoBehaviour
{
    public bool fullscreenBool;
    public bool windowedBool;

    private Button fullscreenButton;

    void Start()
    {
        fullscreenButton = this.GetComponent<Button>();
    }

    void Update()
    {
        if (Screen.fullScreen == true && fullscreenBool == true)
        {
            fullscreenButton.interactable = false;
        } else if (Screen.fullScreen == false && fullscreenBool == true)
        {
            fullscreenButton.interactable = true;
        }

        if (Screen.fullScreen == true && windowedBool == true)
        {
            fullscreenButton.interactable = true;
        }
        else if (Screen.fullScreen == false && windowedBool == true)
        {
            fullscreenButton.interactable = false;
        }
    }

    public void fullscreen()
    {
        Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, true);
        Screen.fullScreen = true;
    }

    public void windowed()
    {
        Screen.fullScreen = false;
    }
}
