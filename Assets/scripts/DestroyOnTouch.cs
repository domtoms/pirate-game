using UnityEngine;

// Destroys the object when a GameObject tagged
// "Player" collides with it.

public class DestroyOnTouch : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        // Begone!

        if (col.tag == "Player")
        {
            Destroy(gameObject);

        }

    }
}
