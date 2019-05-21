using UnityEngine;
using UnityEngine.SceneManagement;

// This script fades to a designated scene when a
// designated key is pressed.

public class MenuButtons : MonoBehaviour
{

    public string levelName;
    public Animator animator;
    //public Animator ship;


    public void letTheAdventureBegin()
    {
        levelName = "intro";
        FadeToScene(1);
    }

    public void setSails()
    {
        levelName = "menu";
        FadeToScene(1);
    }

    public void loreDump()
    {
        levelName = "lore";
        FadeToScene(1);
    }

    public void FadeToScene(int levelIndex)
    {
        // Casuses the designated animator to
        // play an animation titled "fadeout".

        animator.SetTrigger("fadeout");
    }

    public void FadeComplete()
    {
        // Fades to the scene designated in the
        // "levelName" string.

        SceneManager.LoadScene(levelName);
    }
}
