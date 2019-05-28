using UnityEngine;

public class CreditShipLight : MonoBehaviour
{
    public Light lightSource;

    private void Awake()
    {
        lightSource = this.GetComponent<Light>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "ship")
        {
            lightSource.enabled = true;
            //Debug.Log("aa");
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "ship")
        {
            lightSource.enabled = false;
            //Debug.Log("aaa");
        }
    }
}
