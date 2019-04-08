using UnityEngine;

// This script just makes GameObjects spin at the speed
// defined in the "speedX", "speedY" and "speedZ" floats.

public class Spin : MonoBehaviour {

    public float speedX;
    public float speedY;
    public float speedZ;
    
    void Update()
    {

        transform.Rotate(new Vector3(speedX, speedY, speedZ) * Time.deltaTime);
    }
}
