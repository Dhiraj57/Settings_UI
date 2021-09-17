using UnityEngine;

public class PrivacyPolicyHandler : MonoBehaviour
{
    [SerializeField] private GameObject policyUI;
    [SerializeField] private GameObject policyInfo;

    public void PrivacyInfo()
    {
        SoundManager.Instance.Play(SoundManager.Sounds.ButtonClick);
        policyInfo.SetActive(true);
        policyUI.SetActive(false);
    }

    public void Back()
    {
        SoundManager.Instance.Play(SoundManager.Sounds.ButtonClick);
        policyInfo.SetActive(false);
        policyUI.SetActive(true);
    }
}
