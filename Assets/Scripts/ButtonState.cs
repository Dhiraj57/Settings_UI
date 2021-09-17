using UnityEngine;
using UnityEngine.UI;

public class ButtonState : MonoBehaviour
{
    [SerializeField] private Button[] button;
    [SerializeField] private Color disabledColor;
    [SerializeField] private Color enabledColor;
    [SerializeField] private ButtonListType buttonListType;

    private void Start()
    {
        switch(buttonListType)
        {
            case ButtonListType.menuType:
                button[(int)SaveSystem.LoadSettings().menuSelected].gameObject.GetComponent<Image>().color = disabledColor;
                button[(int)SaveSystem.LoadSettings().menuSelected].enabled = false;
                break;

            case ButtonListType.handlingType:
                button[(int)SaveSystem.LoadSettings().handlingType].gameObject.GetComponent<Image>().color = disabledColor;
                button[(int)SaveSystem.LoadSettings().handlingType].enabled = false;
                break;

            case ButtonListType.handType:
                button[(int)SaveSystem.LoadSettings().handType].gameObject.GetComponent<Image>().color = disabledColor;
                button[(int)SaveSystem.LoadSettings().handType].enabled = false;
                break;

            case ButtonListType.graphicsType:
                button[SaveSystem.LoadSettings().qualityIndex].gameObject.GetComponent<Image>().color = disabledColor;
                button[SaveSystem.LoadSettings().qualityIndex].enabled = false;
                break;

            case ButtonListType.languageType:              
                button[(int)SaveSystem.LoadSettings().language].gameObject.GetComponent<Image>().color = disabledColor;
                button[(int)SaveSystem.LoadSettings().language].enabled = false;
                break;
        }
    }

    public void StateChange(int value)
    {
        for (int i=0; i < button.Length; i++)
        {
            button[i].enabled = true;
            button[i].gameObject.GetComponent<Image>().color = enabledColor;
        }

        button[value].gameObject.GetComponent<Image>().color = disabledColor;
        button[value].enabled = false;    
    }

}
