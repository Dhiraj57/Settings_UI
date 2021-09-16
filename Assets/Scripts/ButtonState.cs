using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonState : MonoBehaviour
{
    [SerializeField] private Button[] button;
    [SerializeField] private Color disabledColor;
    [SerializeField] private Color enabledColor;

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
