using UnityEngine;
using UnityEngine.AI;

// Plays the enemy attack animation if the player
// collides with the enemy without attacking. Plays
// the enemy death animation if the player is attacking.

public class EnemyExplode : MonoBehaviour
{
    public GameObject explosion;
    private GameObject player;
    public bool death;
    private Animator enemy;

    private void Awake()
    {
        // Finds the player.

        player = GameObject.Find("Ellen");
        enemy = GetComponent<Animator>();
    }

    void Update()
    {
        if (death == true)
        {
            transform.Translate(Vector3.forward * Time.deltaTime*25);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        // Gets the health system script.
        HealthSystem transScript = player.GetComponent<HealthSystem>();

        if (col.tag == "Player" && transScript.attacking == false)
        {
            // Enemy attack animation.
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }

        if (col.tag == "Player" && transScript.attacking == true)
        {
            // Enemy death animation.
            death = true;
            var euler = transform.eulerAngles;
            euler.y = Random.Range(0f, 360f);
            transform.eulerAngles = euler;
            this.GetComponent<EnemyController>().enabled = false;
            this.GetComponent<SphereCollider>().enabled = false;
            this.GetComponent<NavMeshAgent>().enabled = false;
            enemy.SetTrigger("dies");
            //Destroy(gameObject);
        }
    }
}
