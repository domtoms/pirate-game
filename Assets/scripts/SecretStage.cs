using UnityEngine;

// Nothing happens here.

public class SecretStage : MonoBehaviour
{

    public GameObject selected;
    public bool secretStage;

    void Update()
    {

        if (secretStage == true && Input.GetKey(KeyCode.H) && Input.GetKey(KeyCode.O) && Input.GetKey(KeyCode.N))
        {

            LevelSelect transScript = selected.GetComponent<LevelSelect>();
            transScript.levelID = "honey";
            FindObjectOfType<LevelSelect>().LevelSelected();
        }
    }
}
