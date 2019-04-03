/*
 *  Author: ariel oliveira [o.arielg@gmail.com]
 */

using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public delegate void OnHealthChangedDelegate();
    public OnHealthChangedDelegate OnHealthChangedCallback;



    [SerializeField]
    private float health;
    [SerializeField]
    private float maxHealth;
    [SerializeField]
    private float maxTotalHealth;

    public float Health => health;
    public float MaxHealth => maxHealth;
    public float MaxTotalHealth => maxTotalHealth;

    public void Heal(float value)
    {
        health += value;
        ClampHealth();
    }

    public void TakeDamage(float dmg)
    {
        health -= dmg;
        ClampHealth();
    }

    public void AddHealth()
    {
        if (!(maxHealth < maxTotalHealth)) return;
        maxHealth += 1;
        health = maxHealth;

        OnHealthChangedCallback?.Invoke();
    }

    void ClampHealth()
    {
        health = Mathf.Clamp(health, 0, maxHealth);

        OnHealthChangedCallback?.Invoke();
    }
}
