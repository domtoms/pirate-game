using UnityEngine;

// Allows the player to move the camera with the mouse.
// Camera is locked by the "maxX" and "maxY" floats.

public class CameraMovement : MonoBehaviour
{
    // Floats for the camera position.

    public float speed;
    public float maxX;
    public float maxY;

    private float posX;
    private float posY;

    void Update()
    {

        // Moves the camera with the mouse.

        posY += speed * Input.GetAxis("Mouse X");
        posX -= speed * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(posX, posY, 0.0f);

        // Stops the camera from moving past the "maxX" and
        // "maxY" floats.

        posY = Mathf.Clamp(posY, -maxY, maxY);
        posX = Mathf.Clamp(posX, -maxX, maxX);

    }

}