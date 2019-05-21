using UnityEngine;

public class GlobalAudioMute : MonoBehaviour
{
    public bool mute;

    public void muteSound()
    {
        mute = true;
        AudioListener.volume = 0;

    }

    public void unmuteSound()
    {
        mute = false;
        AudioListener.volume = 1;
    }
}
