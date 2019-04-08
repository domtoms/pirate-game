using UnityEngine;
using UnityEngine.SceneManagement;

// This script fades to a designated scene when a
// designated key is pressed.

public class KeySceneChange : MonoBehaviour {

    public string levelName;
    public Animator animator;
    public bool anyKey;

    void Update() {

        // Triggers the "FadeToScene" void when
        // any key is pressed.

        if (anyKey == true && Input.anyKey)
        {
            FadeToScene(1);
        }

    }

    public void FadeToScene (int levelIndex)
    {
        // Casuses the designated animator to
        // play an animation titled "fadeout".

        animator.SetTrigger("fadeout");
    }

    public void FadeComplete ()
    {
        // Fades to the scene designated in the
        // "levelName" string.

        SceneManager.LoadScene(levelName);
    }
}
