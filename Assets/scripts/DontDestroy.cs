using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Moves the GameObject tagged "music" to the
// "DontDestroyOnLoad" scene.

public class DontDestroy : MonoBehaviour
{
    void Awake()
    {
        GameObject[] item = GameObject.FindGameObjectsWithTag("music");

        if (item.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}