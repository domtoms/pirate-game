using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script will oprn the dialogue box when the
// player presses the "key" KeyCode in a trigger
// marked "npc".

public class Dialogue : MonoBehaviour
{

    public GameObject dialogueBox;
    public Animator dialogueAnimation;
    public KeyCode key;
    public AudioClip speechSound;

    public bool closeDialogue;
    private bool IsOver;
    private AudioSource source;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    // Makes the "prompt" GameObject invisible and closes
    // the dialogue boxwhen the player exits the trigger.
    void OnTriggerExit(Collider col)
    {

        if (col.tag == "npc")
        {
            IsOver = false;
            dialogueAnimation.SetBool("open", false);
        }
    }

    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "npc")
        {
            IsOver = true;
        }
    }

    // Brings up the the "prompt" GameObject and allows the
    // player to open and close the dialogue box with the "key"
    // KeyCode when the player is in a trigger tagged "npc".

    void Update()
    {
        if (Input.GetKeyDown(key) && closeDialogue == false && IsOver == true)
        {
            source.PlayOneShot(speechSound);
            dialogueAnimation.SetBool("open", true);
        }

        if (Input.GetKeyDown(key) && closeDialogue == true && IsOver == true)
        {
            dialogueAnimation.SetBool("open", false);
        }
    }
}
