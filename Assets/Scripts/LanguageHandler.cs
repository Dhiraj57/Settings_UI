using UnityEngine;

public enum Language
{
    English,  
    Spanish,
    French,
    Chinese,
    Latin,
    German,
}

public class LanguageHandler : MonoBehaviour
{
    [SerializeField] private PassData data;
    public Language language;

    public void SelectLanguage(int index)
    {
        switch(index)
        {
            case 0:
                language = Language.English;
                break;

            case 1:
                language = Language.Spanish;
                break;

            case 2:
                language = Language.French;
                break;

            case 3:
                language = Language.Chinese;
                break;

            case 4:
                language = Language.Latin;
                break;

            case 5:
                language = Language.German;
                break;
        }

        LocalizationManager.Instance.LoadLocalizedText(language + ".json");    
    }

}
