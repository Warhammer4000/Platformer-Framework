using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    [Header("Data")]
    public AudioSettings AudioSettings;
    public VideoSettings VideoSettings;
    public GraphicsSettings GraphicsSettings;
    public AccessibilitySettings AccessibilitySettings;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    #region Audio

    public void ChangeMasterVolume(float value)
    {
        AudioSettings.MasterVolume = value;
    }

    public void ChangeSfxVolume(float value)
    {
        AudioSettings.SfxVolume = value;
    }

    public void ChangeAmbianceVolume(float value)
    {
        AudioSettings.AmbianceVolume = value;
    }


    #endregion

    #region Video

    public void FullScreenMode(int value)
    {
        VideoSettings.FullScreenMode =  (FullScreenMode) value;
    }

    #endregion

    #region Graphics

    public void ToggleBloom(bool value)
    {
        GraphicsSettings.Bloom = value;
    }

    #endregion

}
