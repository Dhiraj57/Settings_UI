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
    public Handling handlingType;
    public Hand handType;
    private SettingsData data;

    private void Start()
    {
        data = SaveSystem.LoadSettings();
        handlingType = data.handlingType;
        handType = data.handType;
    }

    public void HandlingControls(int value)
    {
        SoundManager.Instance.Play(SoundManager.Sounds.ButtonClick);

        switch (value)
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
    }

    public void SelectHand(int value)
    {
        SoundManager.Instance.Play(SoundManager.Sounds.ButtonClick);

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
    }

    public void SoundControl(bool tag)
    {
        SoundManager.Instance.Play(SoundManager.Sounds.ButtonClick);

        if(!tag)
        {
            SoundManager.Instance.SetSoundVolume(0);
        }
        else
        {
            SoundManager.Instance.SetSoundVolume(1);
        }
    }

    public void MusicControl(bool tag)
    {
        SoundManager.Instance.Play(SoundManager.Sounds.ButtonClick);
        
        if(!tag)
        {
            SoundManager.Instance.SetMusicVolume(0);
        }
        else
        {
            SoundManager.Instance.SetMusicVolume(1);
        }
    }
}
