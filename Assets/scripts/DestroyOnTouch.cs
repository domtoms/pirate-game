using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Destroys the object when a GameObject tagged
// "Player" collides with it.

public class DestroyOnTouch : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Player")
        {
            Destroy(gameObject);

        }

    }
}
