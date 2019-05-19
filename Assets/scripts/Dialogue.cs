using UnityEngine;

// This script will open the dialogue box when the
// player presses "key" in a trigger marked "npc".

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
        // Gets the dialogue sound effect.

        source = GetComponent<AudioSource>();
    }

    // Makes the "prompt" GameObject invisible and closes
    // the dialogue box when the player exits the trigger.

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
    // player to open and close the dialogue box with "key".

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
