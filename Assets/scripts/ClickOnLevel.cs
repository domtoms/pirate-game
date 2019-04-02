using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Displays the level name when the cursor hovers
// over the level hitbox and activates the level
// upon click.

public class ClickOnLevel : MonoBehaviour
{

    public GameObject selected;
    public GameObject highlight;
    public Text levelNameTextObject;
    public string levelNameText;
    public string levelName;

    void OnMouseOver()
    {
        // Makes the object in the "highlight"
        // GameObject appear.

        levelNameTextObject.text = levelNameText;
        highlight.SetActive(true);
    }

    void OnMouseExit()
    {
        // Makes the object in the "highlight"
        // GameObject disappear.

        highlight.SetActive(false);
    }

    public void OnMouseDown()
    {
        // Loads the level in the "levelName" string.

        LevelSelect transScript = selected.GetComponent<LevelSelect>();
        transScript.levelID = levelName;
        FindObjectOfType<LevelSelect>().LevelSelected();

    }

}
