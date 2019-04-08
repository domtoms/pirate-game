using UnityEngine;

// Plays the enemy attack animation if the player
// collides with the enemy without attacking. Plays
// the enemy death animation if the player is attacking.

public class EnemyExplode : MonoBehaviour
{
    public GameObject explosion;
    private GameObject player;

    private void Awake()
    {
        // Finds the player.

        player = GameObject.Find("Ellen");
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
            Destroy(gameObject);
        }
    }
}
