using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LocalizedText : MonoBehaviour
{
    public string key;

    private void Start()
    {
        TextMeshProUGUI text = GetComponent<TextMeshProUGUI>();
        text.text = LocalizationManager.Instance.GetLocalizedValue(key);
    }
}
