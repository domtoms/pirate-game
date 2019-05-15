using UnityEngine;
using NaughtyCharacter;

// Sets the players coordinates a the "spawn" Vector3
// when the scene begins.


public class Checkpoint : MonoBehaviour
{
    private GameObject player;
    private Vector3 spawn;
    private Vector3 rotation;
    private GameObject coordinates;

    void Awake()
    {
        // Moves the players coordinates.

        Debug.Log("reset");

        player = GameObject.Find("Ellen");
        coordinates = GameObject.Find("scripts");

        SpawnCoordinates spawnScript = coordinates.GetComponent<SpawnCoordinates>();
        spawn = spawnScript.spawnCoord;
        rotation = spawnScript.spawnRotation;

        Character playerScript = player.GetComponent<Character>();
        playerScript._controlRotation = new Vector2(0, rotation.y);

        player.transform.position = new Vector3(spawn.x, spawn.y, spawn.z);
        player.transform.eulerAngles = new Vector3(0, rotation.y, 0);
        player.GetComponent<CharacterController>().enabled = true;

    }
}
