using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

// Changes the text in the "nameObject" GameObject to
// the contents of the "nameText" string.

public class CreditsName : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [TextArea(3, 10)]
    public string nameText;

    public GameObject nameObject;
    public Animator textVisible;

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Makes the text in the "nameObject" GameObject
        // change to the text in the "nameText" string.

        // Triggers the animation to make "nameObject"
        // visible.

        textVisible.SetBool("visible", true);
        GameObject.Find("name").GetComponent<Text>().text = nameText;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Makes "nameObject" invisible when the mouse
        // leaves the hitbox.

        textVisible.SetBool("visible", false);
    }
}
