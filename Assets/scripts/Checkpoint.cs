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
    private GameObject keyHud;
    private Animator keyAnimator;
    private GameObject key;

    void Awake()
    {

        Debug.Log("reset");

        player = GameObject.Find("Ellen");
        coordinates = GameObject.Find("scripts");
        key = GameObject.Find("key");
        keyHud = GameObject.Find("keyhud");

        keyAnimator = keyHud.GetComponent<Animator>();

        SpawnCoordinates spawnScript = coordinates.GetComponent<SpawnCoordinates>();
        spawn = spawnScript.spawnCoord;
        rotation = spawnScript.spawnRotation;

        Character playerScript = player.GetComponent<Character>();
        playerScript._controlRotation = new Vector2(0, rotation.y);

        player.transform.position = new Vector3(spawn.x, spawn.y, spawn.z);
        player.transform.eulerAngles = new Vector3(0, rotation.y, 0);
        player.GetComponent<CharacterController>().enabled = true;

        if (spawnScript.key == true)
        {
            KeyCollection keyScript = player.GetComponent<KeyCollection>();
            keyScript.keyInventory = true;
            keyAnimator.SetBool("open", true);
            Destroy(key);
        }

    }
}
