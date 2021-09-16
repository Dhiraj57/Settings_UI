using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassData : MonoBehaviour
{
    public GraphicsHandler graphics;
    public MenuHandler menuHandler;
    public ControlsHandler controlHandler;

    [HideInInspector] public Menu menuSelected;
    [HideInInspector] public Handling handlingType;
    [HideInInspector] public Hand handType;
    [HideInInspector] public int resolutionIndex;
    [HideInInspector] public int qualityIndex;

    private void Awake()
    {
        resolutionIndex = graphics.resolutionIndex;
        qualityIndex = graphics.qualityIndex;
        menuSelected = menuHandler.menuType;
        handlingType = controlHandler.handlingType;
        handType = controlHandler.handType;
    }

    public void Update()
    {
        resolutionIndex = graphics.resolutionIndex;
        qualityIndex = graphics.qualityIndex;
        menuSelected = menuHandler.menuType;
        handlingType = controlHandler.handlingType;
        handType = controlHandler.handType;
    }
}
