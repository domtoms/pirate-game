using UnityEngine;
using UnityEngine.UI;

public class AddCoin : MonoBehaviour
{
    public float coinCount;
    public Text hudText;

    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "coin")
        {
            coinCount += 1;
            hudText.text = coinCount.ToString();
        }
    }
}
