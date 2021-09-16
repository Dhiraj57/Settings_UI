using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum ButtonListType
{
    menuType,
    graphicsType,
    handlingType,
    handType,
    languageType,
}

public enum Menu
{
    controls,
    language,
    graphics,
    privacyPolicy,
}

public class MenuHandler : MonoBehaviour
{
    [SerializeField] private GameObject settingsUI;
    [SerializeField] private GameObject mainMenuUI;
    [SerializeField] private GameObject controlsMenuUI;
    [SerializeField] private GameObject langaugeMenuUI;
    [SerializeField] private GameObject graphicsMenuUI;
    [SerializeField] private GameObject policyMenuUI;
    [SerializeField] private PassData data;

    public Menu menuType;

    public void PlayMode()
    {
        SoundManager.Instance.Play(SoundManager.Sounds.ButtonClick);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        SoundManager.Instance.Play(SoundManager.Sounds.ButtonClick);
        Application.Quit();
    }

    public void Settings()
    {
        //SoundManager.Instance.Play(SoundManager.Sounds.ButtonClick);
        settingsUI.SetActive(true);
        mainMenuUI.SetActive(false);

        switch(SaveSystem.LoadSettings().menuSelected)
        {
            case Menu.controls:
                Controls();
                break;
            case Menu.graphics:
                Graphics();
                break;
            case Menu.language:
                Language();
                break;
            case Menu.privacyPolicy:
                PrivacyPolicy();
                break;
        }
    }

    public void Controls()
    {
        SoundManager.Instance.Play(SoundManager.Sounds.ButtonClick);
        controlsMenuUI.SetActive(true);
        langaugeMenuUI.SetActive(false);
        graphicsMenuUI.SetActive(false);
        policyMenuUI.SetActive(false);
        menuType = Menu.controls;
    }

    public void Language()
    {
        SoundManager.Instance.Play(SoundManager.Sounds.ButtonClick);
        controlsMenuUI.SetActive(false);
        langaugeMenuUI.SetActive(true);
        graphicsMenuUI.SetActive(false);
        policyMenuUI.SetActive(false);
        menuType = Menu.language;
    }

    public void Graphics()
    {
        SoundManager.Instance.Play(SoundManager.Sounds.ButtonClick);
        controlsMenuUI.SetActive(false);
        langaugeMenuUI.SetActive(false);
        graphicsMenuUI.SetActive(true);
        policyMenuUI.SetActive(false);
        menuType = Menu.graphics;
    }

    public void PrivacyPolicy()
    {
        SoundManager.Instance.Play(SoundManager.Sounds.ButtonClick);
        controlsMenuUI.SetActive(false);
        langaugeMenuUI.SetActive(false);
        graphicsMenuUI.SetActive(false);
        policyMenuUI.SetActive(true);
        menuType = Menu.privacyPolicy;
    }

    public void HoverSound()
    {
        SoundManager.Instance.Play(SoundManager.Sounds.HoverSound);
    }

    public void Back()
    {
        settingsUI.SetActive(false);
        mainMenuUI.SetActive(true);

        SaveSystem.SaveSettings(data);
    }

}
