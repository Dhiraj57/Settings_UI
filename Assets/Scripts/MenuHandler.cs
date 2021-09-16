using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void PlayMode()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Settings()
    {
        settingsUI.SetActive(true);
        mainMenuUI.SetActive(false);
        controlsMenuUI.SetActive(true);
    }

    public void Controls()
    {
        controlsMenuUI.SetActive(true);
        langaugeMenuUI.SetActive(false);
        graphicsMenuUI.SetActive(false);
        policyMenuUI.SetActive(false);
    }

    public void Language()
    {
        controlsMenuUI.SetActive(false);
        langaugeMenuUI.SetActive(true);
        graphicsMenuUI.SetActive(false);
        policyMenuUI.SetActive(false);
    }

    public void Graphics()
    {
        controlsMenuUI.SetActive(false);
        langaugeMenuUI.SetActive(false);
        graphicsMenuUI.SetActive(true);
        policyMenuUI.SetActive(false);
    }

    public void PrivacyPolicy()
    {
        controlsMenuUI.SetActive(false);
        langaugeMenuUI.SetActive(false);
        graphicsMenuUI.SetActive(false);
        policyMenuUI.SetActive(true);
    }

}
