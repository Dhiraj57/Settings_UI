
[System.Serializable]
public class SettingsData 
{
    public Menu menuSelected;
    public Handling handlingType;
    public Hand handType;
    public int resolutionIndex;
    public int qualityIndex;
    public Language language;

    public SettingsData(PassData data)
    {
        resolutionIndex = data.resolutionIndex;
        qualityIndex = data.qualityIndex;
        menuSelected = data.menuSelected;
        handlingType = data.handlingType;
        handType = data.handType;
        language = data.language;
    }
}
