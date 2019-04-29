using UnityEngine;

// Sets the players spawn coordinates to the "checkpoint"
// Vector3 when they collide with the checkpoint trigger.

public class CheckpointTrigger : MonoBehaviour
{
    private Vector3 checkpoint;
    private GameObject coordinates;
    public Animator prompt;

    void Start()
    {
        // Find players starting coordinates
        checkpoint = transform.position;
    }

    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Player")
        {

            coordinates = GameObject.Find("scripts");
            SpawnCoordinates transScript = coordinates.GetComponent<SpawnCoordinates>();
            
            // Sets the spawn coordinates to the checkpoints coordinates.
            if (transScript.spawnCoord != checkpoint)
            {
                Debug.Log("checkpoint " + checkpoint);
                prompt.SetTrigger("visible");
                transScript.spawnCoord = checkpoint;
            }

            // Does nothing if the spawn coordinates are already the checkpoint.
            else if (transScript.spawnCoord == checkpoint)
            {
                Debug.Log("checkpoint already activated");
            }

        }
    }
}
