using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Locks the cursor if the bool is active. Unlocks
// the cursor if the bool is inactive. Activated on
// beginning of scene.

public class LockCursor : MonoBehaviour
{
    public bool locked;

    void Start()
    {
        if (locked == true)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        if (locked == false)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        
    }

}
