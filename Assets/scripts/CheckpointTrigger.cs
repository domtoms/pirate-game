using UnityEngine;
using UnityEngine.UI;

// Sets the players spawn coordinates to the "checkpoint"
// Vector3 when they collide with the checkpoint trigger.

public class CheckpointTrigger : MonoBehaviour
{
    private Vector3 checkpoint;
    private GameObject coordinates;
    private GameObject player;
    public Animator prompt;
    public Text checkpointText;

    void Awake()
    {
        // Finds the checkpoints coordinates
        checkpoint = transform.position;
        player = GameObject.Find("Ellen");
        coordinates = GameObject.Find("scripts");
    }

    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Player")
        {
            KeyCollection keyCollectionScript = player.GetComponent<KeyCollection>();
            SpawnCoordinates spawnScript = coordinates.GetComponent<SpawnCoordinates>();

            // Sets the spawn coordinates to the checkpoints coordinates.
            if (spawnScript.spawnCoord != checkpoint)
            {

                if (keyCollectionScript.keyInventory == true)
                {
                    // save key

                    Debug.Log("checkpoint with key " + checkpoint);

                    spawnScript.key = true;
                    activateCheckpoint();
                }

                else if(keyCollectionScript.keyInventory == false)
                {
                    Debug.Log("checkpoint without key " + checkpoint);

                    // no key
                    activateCheckpoint();
                }
            }

            // Does nothing if the spawn coordinates are already the checkpoint.
            else if (spawnScript.spawnCoord == checkpoint)
            {
                if (keyCollectionScript.keyInventory == spawnScript.key)
                {
                    Debug.Log("checkpoint already activated");
                }

                else if (keyCollectionScript.keyInventory != spawnScript.key)
                {
                    Debug.Log("checkpoint with key " + checkpoint);

                    spawnScript.key = true;
                    activateCheckpoint();
                }
            }

        }
    }

    void activateCheckpoint()
    {
        SpawnCoordinates spawnScript = coordinates.GetComponent<SpawnCoordinates>();
        prompt.SetTrigger("visible");
        checkpointText.text = "Checkpoint!";
        spawnScript.spawnCoord = checkpoint;
        spawnScript.spawnRotation = new Vector3(0, this.transform.eulerAngles.y + 90, 0);
        FindObjectOfType<KeyCollection>().checkpoint();
    }
}
