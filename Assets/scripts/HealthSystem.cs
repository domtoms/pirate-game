using UnityEngine;
using NaughtyCharacter;

// Handles the players health and attacking.

public class HealthSystem : MonoBehaviour
{
    public float health;
    public Animator healthBar;
    public Animator fade;
    public Animator pauseMenu;

    //public KeyCode key;
    private Animator player;
    //public GameObject weapon;
    //public bool attacking;

    public AudioClip hurtSound;
    public AudioClip deathSound;
    public AudioClip attackSound;
    public AudioClip healSound;

    private GameObject scripts;
    private AudioSource source;
    private AudioSource music;

    public AudioClip narutoOP;
    public AudioClip dockMusic;

    public bool narutoMode;


    private void Awake()
    {
        player = GetComponent<Animator>();
        source = GetComponent<AudioSource>();

        scripts = GameObject.Find("scripts");
        music = scripts.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider col)
    {

        // Handles players health on collision with
        // and enemy when not attacking.

        if (col.tag == "enemy" && health > 0 && player.GetBool("Attack") == false)
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

        if (col.tag == "naruto")
        {
            source.PlayOneShot(healSound);
            player.SetBool("naruto", true);

            Character speedScript = this.GetComponent<Character>();


            speedScript.MovementSettings.Acceleration = 50f;
            speedScript.MovementSettings.Decceleration = 50f;

            speedScript.MovementSettings.MaxHorizontalSpeed = 15f;
            speedScript.MovementSettings.JumpSpeed = 15f;
            speedScript.MovementSettings.JumpAbortSpeed = 15f;

            music.clip = narutoOP;

            narutoMode = true;

            music.Play();

        }

        if (col.tag == "death")
        {
            // Instant death collider.
            death();
        }
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Z) && player.GetBool("Attack") == false && player.GetBool("IsGrounded")
            || Input.GetKeyDown(KeyCode.Mouse0) && player.GetBool("Attack") == false && player.GetBool("IsGrounded") && pauseMenu.GetBool("open") == false)
        {
            // Press the "key" KeyCode to attack.
            player.SetBool("Attack", true);
            source.PlayOneShot(attackSound);
        }
    }

    public void death()
    {
        // Triggers fadeout animation upon death.
        source.PlayOneShot(deathSound);
        fade.SetTrigger("fadeout");
        Debug.Log("death");

        if (narutoMode == true)
        {
            music.clip = dockMusic;
            music.Play();
        }
    }

    public void MeleeAttackEnd()
    {
        player.SetBool("Attack", false);
    }

}
