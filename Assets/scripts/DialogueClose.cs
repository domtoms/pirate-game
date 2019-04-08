using UnityEngine;

// Changes the closeDialogue bool.

public class DialogueClose : MonoBehaviour
{
    public GameObject dialogueScript;

    void open()
    {
        Dialogue transScript = dialogueScript.GetComponent<Dialogue>();
        transScript.closeDialogue = true;
    }

    void closed()
    {
        Dialogue transScript = dialogueScript.GetComponent<Dialogue>();
        transScript.closeDialogue = false;
    }

}
