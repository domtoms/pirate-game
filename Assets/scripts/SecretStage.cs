using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script will redirect the player to the main menu
// if the "Escape" key is pressed. It also loads the secret stage
// if the "H", "O" and "N" keys are pressed simultaniously.

public class SecretStage : MonoBehaviour
{

    // The "secretStage" and "escMenu" bools can be used to
    // enable and disable their respective functionalities.

    public GameObject selected;
    public string secret;
    public bool secretStage;
    public bool escMenu;

    void Update()
    {

        // Returns to the main menu if the "Escape" key is
        // pressed.

        if (escMenu == true && Input.GetKeyDown(KeyCode.Escape))
        {
            LevelSelect transScript = selected.GetComponent<LevelSelect>();
            transScript.levelID = "menu";
            FindObjectOfType<LevelSelect>().LevelSelected();
        }

        // Goes to the secret stage if all the keys
        // are pressed.

        if (secretStage == true && Input.GetKey(KeyCode.H) && Input.GetKey(KeyCode.O) && Input.GetKey(KeyCode.N))
        {
            // Loads the level in the "secret" string.

            LevelSelect transScript = selected.GetComponent<LevelSelect>();
            transScript.levelID = secret;
            FindObjectOfType<LevelSelect>().LevelSelected();
        }
    }
}
