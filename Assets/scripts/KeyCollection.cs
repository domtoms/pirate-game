using UnityEngine;
using UnityEngine.UI;

// Allows the player to exit the level after collecting the key

public class KeyCollection : MonoBehaviour
{
    public GameObject nextLevel;
    public Animator prompt;
    public Animator keyHud;
    public Text promptText;
    public KeyCode exitKey;
    [TextArea] public string noKey;
    [TextArea] public string keyAcquired;
    private bool keyInventory;
    public AudioClip keySound;
    private AudioSource source;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider col)
    {
        // Adds the key sprite to the players hud
        if (col.tag == "key")
        {
            keyInventory = true;
            keyHud.SetBool("open", true);
            source.PlayOneShot(keySound);
        }

        // Makes the prompt appear and changes the text
        if (col.tag == "endtrigger")
        {
            prompt.SetBool("open", true);

            if (keyInventory == true)
            {
                promptText.text = keyAcquired;
            }
            else if (keyInventory == false)
            {
                promptText.text = noKey;
            }
        }
    }

    // Hides the prompt when the player leaves the trigger
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "endtrigger")
        {
            prompt.SetBool("open", false);
        }
    }

    // Allows the player press a key to exit the level
    void OnTriggerStay(Collider col)
    {
        if (col.tag == "endtrigger" && keyInventory == true && Input.GetKeyDown(exitKey))
        {
            // Loads the next scene from a script in the endLevel GameObject
            NextLevel transScript = nextLevel.GetComponent<NextLevel>();
            FindObjectOfType<NextLevel>().LevelCompleted();
        }
    }
}