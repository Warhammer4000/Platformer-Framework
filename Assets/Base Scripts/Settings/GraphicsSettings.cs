using System;
using UnityEngine;


[Serializable]
public class GraphicsSettings
{
    public Quality Quality;
    public AntiAliasing AntiAliasing;
    public bool VSync;
    public bool Bloom;
    

  
}

public enum Quality
{
    Low,Medium,High,Custom
}

public enum AntiAliasing
{
    Disabled,X2,X4,X8
}