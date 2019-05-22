using UnityEngine;

public class CratePunch : MonoBehaviour
{
    private GameObject player;
    private Rigidbody rb;
    private Vector3 pos;

    public float force;
    public float radius;
    public float upwards;

    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.Find("Ellen");
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void OnTriggerStay(Collider col)
    {
        HealthSystem transScript = player.GetComponent<HealthSystem>();

        if (col.tag == "Player" && transScript.attacking == true)
        {
            punch();
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "death")
        {
            Destroy(gameObject);
        }
    }

    void punch()
    {
        if (rb.velocity.y == 0f && rb.velocity.x == 0f && rb.velocity.y == 0f)
        {
            pos = player.transform.position;
            rb.AddExplosionForce(force, pos, radius, upwards, ForceMode.VelocityChange);
        }
    }
}
