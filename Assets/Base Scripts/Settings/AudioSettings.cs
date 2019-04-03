using System;

using UnityEngine;

[Serializable]
public class AudioSettings
{
    [Range(0,1)]
    public float MasterVolume;
    [Range(0, 1)]
    public float SfxVolume;
    [Range(0, 1)]
    public float AmbianceVolume;
}
