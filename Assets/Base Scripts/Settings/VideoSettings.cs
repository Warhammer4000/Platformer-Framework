using System;
using UnityEngine;


[Serializable]
public class VideoSettings
{
    public FullScreenMode FullScreenMode;

    [SerializeField] private Vector2Int ScreenResolution;

    public Resolution Resolution
    {
        get => new Resolution {height = ScreenResolution.x, width = ScreenResolution .y};
        set
        {
            ScreenResolution.x = value.height;
            ScreenResolution.y = value.width;
        }
    }

}


