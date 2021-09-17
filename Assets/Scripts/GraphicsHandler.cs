using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GraphicsHandler : MonoBehaviour
{
    Resolution[] resolutions;
    [HideInInspector] public int resolutionIndex;
    [HideInInspector] public int qualityIndex;

    private SettingsData data;

    [SerializeField] private TMP_Dropdown resolutionDropdown;

    private void Start()
    {
        data = SaveSystem.LoadSettings();
        
        qualityIndex = data.qualityIndex;
        resolutionIndex = data.resolutionIndex;

        ResolutionSetting();
        InitialSetttings();
    }

    private void InitialSetttings()
    {
        QualitySettings.SetQualityLevel(qualityIndex);
        //resolutionIndex = data.resolutionIndex;

        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);

        resolutionDropdown.value = resolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetQuality(int value)
    {
        SoundManager.Instance.Play(SoundManager.Sounds.ButtonClick);
        QualitySettings.SetQualityLevel(value);

        qualityIndex = value;
    }

    public void SetFullscreen(bool isFullscreen)
    {
        SoundManager.Instance.Play(SoundManager.Sounds.ButtonClick);
        Screen.fullScreen = isFullscreen;
    }

    public void SetResolution(int resolutionIndex)
    {
        SoundManager.Instance.Play(SoundManager.Sounds.ButtonClick);
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
        this.resolutionIndex = resolutionIndex;
    }

    private void ResolutionSetting()
    {
        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);
            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();       
    }
}
