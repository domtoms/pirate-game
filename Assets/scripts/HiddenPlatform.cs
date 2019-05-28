using UnityEngine;

public class HiddenPlatform : MonoBehaviour
{
    public Animator platformAnimator;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            platformAnimator.SetBool("activated", true);
        }
    }

    void OnTriggerExit(Collider col)
    {

        if (col.tag == "Player")
        {
            platformAnimator.SetBool("activated", false);
        }
    }
}
