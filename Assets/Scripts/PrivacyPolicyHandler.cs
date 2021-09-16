﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrivacyPolicyHandler : MonoBehaviour
{
    [SerializeField] private GameObject policyUI;
    [SerializeField] private GameObject policyInfo;

    public void PrivacyInfo()
    {
        policyInfo.SetActive(true);
        policyUI.SetActive(false);
    }

    public void Back()
    {
        policyInfo.SetActive(false);
        policyUI.SetActive(true);
    }
}
