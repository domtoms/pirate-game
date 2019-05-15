using UnityEngine;

// Triggers level end after cutscene

public class EndCutscene : MonoBehaviour
{
    public GameObject fade;
    public AudioClip takeoffSound;
    private GameObject cutsceneCamera;
    private AudioSource source;

    void takeoff()
    {
        cutsceneCamera = GameObject.Find("endcamera");
        source = cutsceneCamera.GetComponent<AudioSource>();
        source.PlayOneShot(takeoffSound);
    }

    void cutsceneFinished()
    {
        NextLevel transScript = fade.GetComponent<NextLevel>();
        FindObjectOfType<NextLevel>().FadeToScene(1);
    }
}
