using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MainMenu : MonoBehaviour
{
    public Vector2 screenScale;

    public bool toggleGrid, toggleLabel;
    public bool showMenuPanel, showOptionsPanel;
    public Light sunLight;
    public bool tempBool;
    void Start()
    {
        sunLight = GameObject.FindGameObjectWithTag("Light").GetComponent<Light>();
    }
    #region OnGUI - Renderer for IMGUI

    void OnGUI()
    {
        screenScale.x = Screen.width / 16;
        screenScale.y = Screen.height / 9;

        Grid();
        Menu();
        Options();
    }
    #endregion
    #region Grid Reference
    void Grid()
    {
            
            if(toggleGrid)
            {
                

    }