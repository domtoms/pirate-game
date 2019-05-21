using UnityEngine;
using UnityEngine.UI;

public class MuteAudio : MonoBehaviour
{
    private GameObject globalMute;

    public bool muteButton;
    public bool unmuteButton;
    public AudioSource audioSource;

    private Button audioButton;

    public void Awake()
    {
        globalMute = GameObject.Find("globalaudiomute");
        GlobalAudioMute muteScript = globalMute.GetComponent<GlobalAudioMute>();

        audioButton = this.GetComponent<Button>();
    }

    public void turnOffTheSound()
    {
        FindObjectOfType<GlobalAudioMute>().muteSound();
        audioSource.Stop();
    }

    public void turnOnTheSound()
    {
        FindObjectOfType<GlobalAudioMute>().unmuteSound();
        audioSource.Play();
    }

    void Update()
    {

        if (muteButton == true && AudioListener.volume == 0)
        {
            audioButton.interactable = false;
        }
        else if (muteButton == true && AudioListener.volume == 1)
        {
            audioButton.interactable = true;
        }

        if (unmuteButton == true && AudioListener.volume == 0)
        {
            audioButton.interactable = true;
        }
        else if (unmuteButton == true && AudioListener.volume == 1)
        {
            audioButton.interactable = false;
        }
    }

}
