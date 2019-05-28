using UnityEngine;

// Triggers level end after cutscene

public class MenuFlyAway : MonoBehaviour
{
    public GameObject fade;
    private Animator ship;
    public AudioSource audioSource;
    public AudioClip soundFX;
    private bool takeoff;


    private void Update()
    {
        if (Input.anyKeyDown && takeoff == false)
        {
            audioSource.PlayOneShot(soundFX);
            takeoff = true;
            flyAway();
        }
    }


    private void Awake()
    {
        ship = GetComponent<Animator>();
    }

    public void flyAway()
    {
        ship.SetTrigger("begone");
    }

    public void beginGame()
    {
        MenuButtons transScript = fade.GetComponent<MenuButtons>();
        FindObjectOfType<MenuButtons>().setSails();
    }
}
