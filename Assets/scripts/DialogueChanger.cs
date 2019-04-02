using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This script will change the contents of the dialogue
// box When the player collides with the hitbox of the
// npc.

public class DialogueChanger : MonoBehaviour
{
    private GameObject promptObject;
    private Animator promptAnimator;
    private Text npcName;
    private Text dialogue;
    private Vector3 location;

    public float height = 2.2f;
    public string nameText;

    [TextArea(3, 10)]
    public string dialogueText;

    public GameObject npc;

    void Start()
    {
        promptObject = GameObject.Find("!");
        promptAnimator = promptObject.GetComponent<Animator>();
        npcName = GameObject.Find("name").GetComponent<Text>();
        dialogue = GameObject.Find("dialogue").GetComponent<Text>();
        location = npc.transform.position;
    }

    void OnTriggerEnter(Collider col)
    {
        // Sets the name text item in the dialogue box
        // to "nameText"and the dialogue to "dialogueText"
        // when the player collides with the hitbox.

        if (col.tag == "Player")
        {
            promptObject.transform.position = new Vector3(location.x,location.y+height,location.z);
            npcName.text = nameText;
            dialogue.text = dialogueText;
            promptAnimator.SetBool("open", true);
        }
    }

    void OnTriggerExit(Collider col)
    {

        if (col.tag == "Player")
        {
            promptAnimator.SetBool("open", false);
        }

    }
}
