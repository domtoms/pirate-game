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

            MenuButtons transScript = selected.GetComponent<MenuButtons>();
            transScript.levelName = "honey";
            FindObjectOfType<MenuButtons>().FadeToScene(1);
        }
    }
}
