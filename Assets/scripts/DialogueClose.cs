using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Sets the closeDialogue bool true.

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
