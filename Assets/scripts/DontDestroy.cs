using UnityEngine;

// Moves the GameObject tagged "music" to the
// "DontDestroyOnLoad" scene and destroys duplicates.

public class DontDestroy : MonoBehaviour
{
    public string itemTag;

    void Awake()
    {
        GameObject[] item = GameObject.FindGameObjectsWithTag(itemTag);

        if (item.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}