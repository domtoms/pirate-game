using UnityEngine;
using UnityEngine.UI;

// This script will add the key to the players inventory
// and modify the trigger at the end of the level.

public class KeyCollection : MonoBehaviour
{
    public GameObject key;
    public GameObject endLevel;
    public bool keyInventory;
    public Animator promptAnimator;
    public Animator KeyHud;
    public Text promptText;

    [TextArea(3, 10)]
    public string noKey;

    [TextArea(3, 10)]
    public string keyAcquired;
    public KeyCode exitKey;

    void OnTriggerEnter(Collider col)
    {

        // Adds the "hud" sprite to the players hud and destroys
        // the "key" GameObject upon collision.

        if (col.tag == "key")
        {
            key.SetActive(false);
            keyInventory = true;
            KeyHud.SetBool("collected", true);

        }


        // Changes the prompt to the "keyAcquired" or
        // "noKey" text based on the "keyInventory" bool.

        if (col.tag == "endtrigger")
        {

            promptAnimator.SetBool("open", true);

            if (keyInventory == true)
            {
                promptText.text = keyAcquired;
            }

            if (keyInventory == false)
            {
                promptText.text = noKey;
            }

        }

    }

    // Triggers the level exit if the player presses "exitKey"
    // in the exit trigger if the "keyInventory" bool is true.

    void OnTriggerStay(Collider col)
    {

        if (keyInventory == true && col.tag == "endtrigger" && Input.GetKeyDown(exitKey))
        {
            NextLevel transScript = endLevel.GetComponent<NextLevel>();
            FindObjectOfType<NextLevel>().LevelCompleted();
        }

    }


    // Hides the exit level text when the player leaves
    // the trigger.

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "endtrigger")
        {
            promptAnimator.SetBool("open", false);
        }
    }

}
