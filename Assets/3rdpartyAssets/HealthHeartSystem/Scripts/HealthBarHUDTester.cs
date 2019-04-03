/*
 *  Author: ariel oliveira [o.arielg@gmail.com]
 */

using UnityEngine;

public class HealthBarHUDTester : MonoBehaviour
{
    [SerializeField]private PlayerStats stats;
    public void AddHealth()
    {
        stats.AddHealth();
    }

    public void Heal(float health)
    {
        stats.Heal(health);
    }

    public void Hurt(float dmg)
    {
        stats.TakeDamage(dmg);
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Hurt(1);
        }

        if (Input.GetButtonDown("Fire2"))
        {
            Heal(5);
        }
    }

}
