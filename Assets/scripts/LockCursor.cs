using UnityEngine;

// Locks the cursor depending on the "locked" bool.
// Activated on the beginning of the scene.

public class LockCursor : MonoBehaviour
{
    public bool locked;

    void Awake()
    {
        if (locked == true)
        {
            // Locks the cursor!

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        if (locked == false)
        {
            // Unlocks the cursor!

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        
    }

}
