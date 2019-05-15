using UnityEngine;

// Sets the players spawn coordinates to the "checkpoint"
// Vector3 when they collide with the checkpoint trigger.

public class CheckpointTrigger : MonoBehaviour
{
    private Vector3 checkpoint;
    private GameObject coordinates;
    private GameObject player;
    public Animator prompt;

    void Awake()
    {
        // Finds the checkpoints coordinates
        checkpoint = transform.position;
        //KeyCollection transScript = player.GetComponent<KeyCollection>();
    }

    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Player")
        {

            coordinates = GameObject.Find("scripts");
            SpawnCoordinates spawnScript = coordinates.GetComponent<SpawnCoordinates>();
            
            // Sets the spawn coordinates to the checkpoints coordinates.
            if (spawnScript.spawnCoord != checkpoint)
            {
                Debug.Log("checkpoint " + checkpoint);
                prompt.SetTrigger("visible");
                spawnScript.spawnCoord = checkpoint;
                spawnScript.spawnRotation = new Vector3(0, this.transform.eulerAngles.y +90, 0);
                FindObjectOfType<KeyCollection>().checkpoint();
            }

            // Does nothing if the spawn coordinates are already the checkpoint.
            else if (spawnScript.spawnCoord == checkpoint)
            {
                Debug.Log("checkpoint already activated");
            }

        }
    }
}
