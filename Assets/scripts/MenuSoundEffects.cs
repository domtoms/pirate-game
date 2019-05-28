using UnityEngine;

public class MenuSoundEffects : MonoBehaviour
{
    public AudioClip hover;
    public AudioClip click;

    public AudioSource audioSource;

    // Start is called before the first frame update
    public void playHoverSound()
    {
        audioSource.PlayOneShot(hover);
    }

    // Update is called once per frame
    public void playClickSound()
    {
        audioSource.PlayOneShot(click);
    }
}
