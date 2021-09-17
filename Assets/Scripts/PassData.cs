using UnityEngine;

public class PassData : MonoBehaviour
{
    public GraphicsHandler graphics;
    public MenuHandler menuHandler;
    public ControlsHandler controlHandler;
    public LanguageHandler languageHandler;

    [HideInInspector] public Menu menuSelected;
    [HideInInspector] public Handling handlingType;
    [HideInInspector] public Hand handType;
    [HideInInspector] public int resolutionIndex;
    [HideInInspector] public int qualityIndex;
    [HideInInspector] public Language language;

    private void Awake()
    {
        resolutionIndex = graphics.resolutionIndex;
        qualityIndex = graphics.qualityIndex;
        menuSelected = menuHandler.menuType;
        handlingType = controlHandler.handlingType;
        handType = controlHandler.handType;
        language = languageHandler.language;
    }

    public void Update()
    {
        resolutionIndex = graphics.resolutionIndex;
        qualityIndex = graphics.qualityIndex;
        menuSelected = menuHandler.menuType;
        handlingType = controlHandler.handlingType;
        handType = controlHandler.handType;
        language = languageHandler.language;
    }
}
