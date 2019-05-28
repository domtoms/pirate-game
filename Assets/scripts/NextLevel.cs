using UnityEngine;
using UnityEngine.SceneManagement;

// Fades to the next scene. Also used to handle
// respawning upon death.

public class NextLevel : MonoBehaviour
{
    public string nextLevel;
    public Animator animator;
    public GameObject player;
    public GameObject playerCamera;
    public GameObject cutsceneCamera;
    public Animator endCutscene;
    public Animator letterbox;
    public bool endLevel;

    public GameObject pauseMenu;
    public Animator pauseAnimator;

    public GameObject lod1;
    public GameObject lod2;
    public GameObject lod3;

    public void LevelCompleted()
    {
        // This void will be triggered by the
        // "KeyCollection" script.

        endLevel = true;
        Destroy(player);
        Destroy(playerCamera);
        cutsceneCamera.SetActive(true);
        letterbox.SetBool("open", true);
        endCutscene.SetTrigger("play");

        GameObject[] UI = GameObject.FindGameObjectsWithTag("ui");
        foreach (GameObject ui in UI)
        GameObject.Destroy(ui);
        GameObject.Destroy(lod1);
        GameObject.Destroy(lod2);
        GameObject.Destroy(lod3);

        Pause transscript = pauseMenu.GetComponent<Pause>();

        transscript.lockPause = true;

        if (pauseAnimator.GetBool("open") == true)
        {
            pauseAnimator.SetBool("open", false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    public void FadeToScene(int levelIndex)
    {
        // Plays the animation titled "fadeout"
        // in the designated animatior.

        animator.SetTrigger("fadeout");
    }

    public void FadeComplete()
    {

        // Reloads the scene if the "endLevel" bool
        // is false.

        if (endLevel == false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }

        // Loads the level in the "nextLevel" string
        // if the "endLevel" bool is true.

        if (endLevel == true)
        {
            Destroy(GameObject.FindWithTag("music"));

            SceneManager.LoadScene(nextLevel);
        }
    }

    public void exitToMenu(int levelIndex)
    {
        nextLevel = "menu";
        endLevel = true;
        animator.SetTrigger("fadeout");
    }
}
