using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Handling
{
    steering,
    touchpad,
    tilt,
}

public enum Hand
{
    left,
    right
}

public class ControlsHandler : MonoBehaviour
{
    private Handling handlingType;
    private Hand handType;

    public void HandlingControls(int value)
    {
        switch(value)
        {
            case 0:
                handlingType = Handling.steering;
                break;
            case 1:
                handlingType = Handling.touchpad;
                break;
            case 2:
                handlingType = Handling.tilt;
                break;
            default:
                handlingType = Handling.steering;
                break;
        }

        Debug.Log(handlingType);

    }

    public void SelectHand(int value)
    {
        switch (value)
        {
            case 0:
                handType = Hand.left;
                break;
            case 1:
                handType = Hand.right;
                break;
            default:
                handType = Hand.right;
                break;
        }

        Debug.Log(handType);
    }

    public void SoundControl(bool tag)
    {
        Debug.Log(tag);
    }

    public void MusicControl(bool tag)
    {
        Debug.Log(tag);
    }
}
