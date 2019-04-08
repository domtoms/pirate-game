using UnityEngine;
using UnityEngine.SceneManagement;

// This script will load a level the level in
// the "levelID" string.

public class LevelSelect : MonoBehaviour {

    public string levelID;
    public Animator animator;

    public void LevelSelected()
    {
        // This void will be triggered by another
        // script.

        FadeToScene(1);
    }

    public void FadeToScene(int levelIndex)
    {
        // Triggers the "fadeout" trigger in
        // the designated animator.

        animator.SetTrigger("fadeout");
    }

    public void FadeComplete()
    {
        // Loads the level in the "levelID string
        // when the fadeout animation has completed.

        SceneManager.LoadScene(levelID);
    }

}
