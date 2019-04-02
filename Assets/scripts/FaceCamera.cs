using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Makes the object always face the camera.

public class FaceCamera : MonoBehaviour
{
    void Update()
    {
        transform.LookAt(Camera.main.transform.position, Vector3.up);
    }
}
