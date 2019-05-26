using UnityEngine;
using UnityEngine.UI;

// This script will change the contents of the dialogue
// box When the player collides npc's hitbox.

public class DialogueChanger : MonoBehaviour
{
    private GameObject promptObject;
    private Animator promptAnimator;
    private Text npcName;
    private Text dialogue;
    private Vector3 location;
    public bool missingEye;

    public Animator questHeadline;
    public Text questText;
    
    private GameObject player;

    public float height = 2.2f;

    public string nameText;
    public string missingEyeNameText;

    [TextArea(3, 10)]
    public string dialogueText;

    [TextArea(3, 10)]
    public string missingEyeDialogue;

    public GameObject npc;

    void Start()
    {
        // Gets all the neccicary components.

        promptObject = GameObject.Find("!");
        promptAnimator = promptObject.GetComponent<Animator>();
        npcName = GameObject.Find("name").GetComponent<Text>();
        dialogue = GameObject.Find("dialogue").GetComponent<Text>();
        location = npc.transform.position;
        player = GameObject.Find("Ellen");
    }

    void OnTriggerEnter(Collider col)
    {
        // Sets the name to "nameText" and the dialogue
        // to "dialogueText" when the player enters the
        // npc's hitbox.

        if (col.tag == "Player")
        {
            KeyCollection transScript = player.GetComponent<KeyCollection>();
            Dialogue dialogueScript = player.GetComponent<Dialogue>();

            if (missingEye == true && transScript.eye == true)
            {
                npcName.text = missingEyeNameText;
                dialogue.text = missingEyeDialogue;
                dialogueScript.overMissingEye = true;

            }else
            {
                npcName.text = nameText;
                dialogue.text = dialogueText;
            }

            promptObject.transform.position = new Vector3(location.x,location.y+height,location.z);
            promptAnimator.SetBool("open", true);
        }
    }

    void OnTriggerExit(Collider col)
    {

        // Hides dialogue prompt when the player walks away.

        if (col.tag == "Player")
        {
            promptAnimator.SetBool("open", false);

            KeyCollection transScript = player.GetComponent<KeyCollection>();

            if (missingEye == true)
            {
                Dialogue dialogueScript = player.GetComponent<Dialogue>();
                dialogueScript.overMissingEye = false;

            }
        }

    }
}
