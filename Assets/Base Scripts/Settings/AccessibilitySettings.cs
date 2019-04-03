using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class AccessibilitySettings
{
    public bool Subtitle;
    [Range(20,50)]
    public int FontSize;
    public bool FontOutline;
    public Color OutlineColor;

}
