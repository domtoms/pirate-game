using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Sets the players spawn coordinates to the "checkpoint"
// Vector3 when they collide with the checkpoint trigger.

public class CheckpointTrigger : MonoBehaviour
{
    public Vector3 checkpoint;
    private GameObject spawnScript;
    public Animator prompt;

    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Player")
        {

            spawnScript = GameObject.Find("scripts");
            SpawnCoordinates transScript = spawnScript.GetComponent<SpawnCoordinates>();
            
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
