using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LocalizationManager : MonoBehaviour
{
    private static LocalizationManager instance;
    public static LocalizationManager Instance { get { return instance; } }

    private Dictionary<string, string> localizedText;
    private bool isReady = false;
    private string missingText = "Text not found";


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        LoadLocalizedText(SaveSystem.LoadSettings().language + ".json");
    }

    public void LoadLocalizedText(string fileName)
    {
        localizedText = new Dictionary<string, string>();
        string filePath = Path.Combine(Application.streamingAssetsPath, fileName);

        if(File.Exists(filePath))
        {
            string dataAsJason = File.ReadAllText(filePath);
            LocalizationData loadedData = JsonUtility.FromJson<LocalizationData>(dataAsJason);

            for(int i = 0; i < loadedData.items.Length; i++)
            {
                localizedText.Add(loadedData.items[i].key, loadedData.items[i].value);
            }
        }

        isReady = true;
    }

    public string GetLocalizedValue(string key)
    {
        string result = missingText;
        if(localizedText.ContainsKey(key))
        {
            result = localizedText[key];
        }

        return result;
    }

    public bool GetIsReady()
    {
        return isReady;
    }
}
