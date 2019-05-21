using UnityEngine;

// Triggers level end after cutscene

public class MenuFlyAway : MonoBehaviour
{
    public GameObject fade;
    private Animator ship;


    private void Update()
    {
        if (Input.anyKey)
        {
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
