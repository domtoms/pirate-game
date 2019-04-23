using UnityEngine;

// Triggers level end after cutscene

public class EndCutscene : MonoBehaviour
{
    public GameObject fade;

    void cutsceneFinished()
    {
        NextLevel transScript = fade.GetComponent<NextLevel>();
        FindObjectOfType<NextLevel>().FadeToScene(1);
    }
}
