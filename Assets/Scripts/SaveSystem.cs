using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem 
{
    public static void SaveSettings(PassData data)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/settings.txt";
        FileStream stream = new FileStream(path, FileMode.Create);

        SettingsData saveData = new SettingsData(data);

        formatter.Serialize(stream, saveData);
        stream.Close();
    }

    public static SettingsData LoadSettings()
    {
        string path = Application.persistentDataPath + "/settings.txt";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SettingsData loadData =  formatter.Deserialize(stream) as SettingsData;
            stream.Close();

            return loadData;
        }
        else
        {
            return null;
        }
    }
}
