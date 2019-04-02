using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This script will load a level after it has been
// selected in the level select screen. It will
// load the level in the "levelID" string.

public class LevelSelect : MonoBehaviour {

    public string levelID;
    public Animator animator;

    public void LevelSelected()
    {
        // This void will be triggered by the
        // "clickonlevel" script.

        FadeToScene(1);
    }

    public void FadeToScene(int levelIndex)
    {
        // Plays the animation titled "fadeout"
        // in the designated animatior.

        animator.SetTrigger("fadeout");
    }

    public void FadeComplete()
    {
        // Loads the level in the "levelID string
        // when the fadeout animation has completed.

        SceneManager.LoadScene(levelID);
    }

}
