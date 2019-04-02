using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Sets the players coordinates a the "spawn" Vector3
// when the scene begins.


public class Checkpoint : MonoBehaviour
{
    private GameObject player;
    private Vector3 spawn;
    private GameObject coordinates;

    void Awake()
    {
        Debug.Log("reset");

        player = GameObject.Find("Ellen");
        coordinates = GameObject.Find("scripts");

        SpawnCoordinates transScript = coordinates.GetComponent<SpawnCoordinates>();
        spawn = transScript.spawnCoord;

        player.transform.position = new Vector3(spawn.x, spawn.y, spawn.z);
        player.GetComponent<CharacterController>().enabled = true;

    }
}
