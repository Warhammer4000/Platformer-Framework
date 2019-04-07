using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HudManager : MonoBehaviour
{
    [SerializeField] private string HudScene;
    void Awake()
    {
        SceneManager.LoadScene(HudScene, LoadSceneMode.Additive);
    }
}
