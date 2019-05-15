using UnityEngine;

// Handles the players health and attacking.

public class HealthSystem : MonoBehaviour
{
    public float health;
    public Animator healthBar;
    public Animator fade;

    public KeyCode key;
    private Animator player;
    public GameObject weapon;
    public bool attacking;

    public AudioClip hurtSound;
    public AudioClip deathSound;
    public AudioClip attackSound;
    public AudioClip healSound;

    private AudioSource source;


    private void Awake()
    {
        player = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider col)
    {

        // Handles players health on collision with
        // and enemy when not attacking.

        if (col.tag == "enemy" && health > 0 && attacking == false)
        {
            if (health > 0)
            {
                // Health subtraction.
                source.PlayOneShot(hurtSound);
                health -= 1;
                healthBar.SetTrigger("loss");
            }

            if (health == 0)
            {
                // Dies when at 0 health.
                death();
            }
        }

        if (col.tag == "healthpickup")
        {
            source.PlayOneShot(healSound);
            //Destroy(col);

            if (health < 3)
            {
                //Health Restoration.
                health += 1;
                healthBar.SetTrigger("regen");
            }

        }

        if (col.tag == "death")
        {
            // Instant death collider.
            death();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown("x"))
        {
            // Press "x" to commit suicide.
            death();
        }

        if (Input.GetKeyDown(key) && attacking == false && player.GetBool("IsGrounded"))
        {
            // Press the "key" KeyCode to attack.
            player.SetTrigger("Attack");
        }
    }

    public void death()
    {
        // Triggers fadeout animation upon death.
        source.PlayOneShot(deathSound);
        fade.SetTrigger("fadeout");
        Debug.Log("death");

    }

    public void MeleeAttackStart()
    {
        // Begin Melee Attack.
        source.PlayOneShot(attackSound);
        attacking = true;
        weapon.SetActive(true);
    }

    public void MeleeAttackEnd()
    {
        // End Melee Attack.
        attacking = false;
        weapon.SetActive(false);
    }

}
