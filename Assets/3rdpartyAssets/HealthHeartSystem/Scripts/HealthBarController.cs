/*
 *  Author: ariel oliveira [o.arielg@gmail.com]
 */

using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(PlayerStats))]
public class HealthBarController : MonoBehaviour
{
    [SerializeField]private PlayerStats stats;
    private GameObject[] heartContainers;
    private Image[] heartFills;

    public Transform heartsParent;
    public GameObject heartContainerPrefab;

    private void Start()
    {
        // Should I use lists? Maybe :)
        heartContainers = new GameObject[(int)stats.MaxTotalHealth];
        heartFills = new Image[(int)stats.MaxTotalHealth];

        stats.OnHealthChangedCallback += UpdateHeartsHUD;
        InstantiateHeartContainers();
        UpdateHeartsHUD();
    }

    public void UpdateHeartsHUD()
    {
        SetHeartContainers();
        SetFilledHearts();
    }

    void SetHeartContainers()
    {
        for (int i = 0; i < heartContainers.Length; i++)
        {
            heartContainers[i].SetActive(i < stats.MaxHealth);
        }
    }

    void SetFilledHearts()
    {
        for (int i = 0; i < heartFills.Length; i++)
        {
            heartFills[i].fillAmount = i < stats.Health ? 1 : 0;
        }

        if (stats.Health % 1 == 0) return;
        int lastPos = Mathf.FloorToInt(stats.Health);
        heartFills[lastPos].fillAmount = stats.Health % 1;
    }

    void InstantiateHeartContainers()
    {
        for (int i = 0; i < stats.MaxTotalHealth; i++)
        {
            GameObject temp = Instantiate(heartContainerPrefab);
            temp.transform.SetParent(heartsParent, false);
            heartContainers[i] = temp;
            heartFills[i] = temp.transform.Find("HeartFill").GetComponent<Image>();
        }
    }
}
