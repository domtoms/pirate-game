using UnityEngine;
using UnityEngine.AI;

public class EnemyExplode : MonoBehaviour
{
    public GameObject explosion;
    private GameObject player;
    private Animator playerAnimator;
    private Animator enemy;
    private bool death;

    void Awake()
    {
        // Finds player and enemy animator
        player = GameObject.Find("Ellen");
        playerAnimator = player.GetComponent<Animator>();
        enemy = GetComponent<Animator>();
    }

    void Update()
    {

        // Begone!
        if (death == true)
        {
            transform.Translate(Vector3.back * Time.deltaTime * 30);
        }
    }

    void rip()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter(Collider col)
    {
        // Gets the health system
        HealthSystem transScript = player.GetComponent<HealthSystem>();

        // Enemy explodes and hurts player
        if (col.tag == "Player" && playerAnimator.GetBool("Attack") == false)
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }

        // Enemy flies off into the sunset and dies
        if (col.tag == "Player" && playerAnimator.GetBool("Attack") == true)
        {
            // Activates death mode
            death = true;

            // Changes enemy rotation
            Vector3 euler = transform.eulerAngles;
            euler.y = Random.Range(player.transform.eulerAngles.y +145f, player.transform.eulerAngles.y +215f);
            transform.eulerAngles = euler;
            Debug.Log("enemy rotation " + euler);

            //transform.eulerAngles = new Vector3(0f, player.transform.eulerAngles.y, 0f);

            // Disable enemy AI
            this.GetComponent<EnemyController>().enabled = false;
            this.GetComponent<NavMeshAgent>().enabled = false;

            // Trigger death animation
            enemy.SetTrigger("dies");
        }
    }
}
