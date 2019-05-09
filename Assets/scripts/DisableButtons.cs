using UnityEngine;
using UnityEngine.UI;

public class DisableButtons : MonoBehaviour
{
    public int buttonQualityLevel;
    private int qualityLevel;
    private Button qualityButton;

    void Start()
    {
        qualityButton = this.GetComponent<Button>();
    }

    void Update()
    {
        int qualityLevel = QualitySettings.GetQualityLevel();

        if (qualityLevel == buttonQualityLevel)
        {
            qualityButton.interactable = false;
        } else if (qualityLevel != buttonQualityLevel)
        {
            qualityButton.interactable = true;
        }
    }

    public void click()
    {
        QualitySettings.SetQualityLevel(buttonQualityLevel, true);
    }
}
