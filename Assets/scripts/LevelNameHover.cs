using UnityEngine;

// Makes the item follow the cursor.

public class LevelNameHover : MonoBehaviour
{
    void Update()
    {
        transform.position = Input.mousePosition;
    }
}
