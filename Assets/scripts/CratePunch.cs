using UnityEngine;

public class CratePunch : MonoBehaviour
{
    private GameObject player;
    private Rigidbody rb;
    private Vector3 pos;

    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.Find("Ellen");
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            pos = player.transform.position;
            punch();
        }
    }

    void punch()
    {
        if (rb != null)
        {
            rb.AddExplosionForce(25f, pos, 10f, 10f, ForceMode.VelocityChange);
        }
    }
}
