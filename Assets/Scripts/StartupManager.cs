﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartupManager : MonoBehaviour
{
    private IEnumerator Start()
    {
        while(!LocalizationManager.Instance.GetIsReady())
        {
            yield return null;
        }

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
