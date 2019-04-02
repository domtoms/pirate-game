using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This script waits for a desginated duration before
// fading a desginated scene.

public class WaitToFade : MonoBehaviour
{
    public float timer;
    public string levelName;
    public Animator animator;

    void Start()
    {
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        // triggers the "FadeToScene" void after waiting
        // for the amount of seconds designated in the
        // "timer" float.

        yield return new WaitForSeconds(timer);
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
