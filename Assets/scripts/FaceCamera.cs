using UnityEngine;

// Makes the object always face the camera. Used for
// forward facing sprites.

public class FaceCamera : MonoBehaviour
{
    void Update()
    {
        // Look at me!

        transform.LookAt(Camera.main.transform.position, Vector3.up);
    }
}
