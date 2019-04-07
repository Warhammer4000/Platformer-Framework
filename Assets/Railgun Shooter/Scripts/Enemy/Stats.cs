using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class Stats
{
    public int MaxHealth;
    public int CurrentHealth;
    public int Damage;
    public bool HeadShotDisabled;

    public bool IsDead;
   


    public UnityEvent OnDeath;

    public void ApplyDamage(int amount)
    {
        if(IsDead)return;
        if (CurrentHealth - amount <= 0)
        {
            IsDead = true;
            CurrentHealth = 0;
            OnDeath?.Invoke();
        }

        if (CurrentHealth - amount > 0)
        {
            CurrentHealth -= amount;
        }
       
    }

    public void HeadShot()
    {
        if(HeadShotDisabled)return;
        ApplyDamage(MaxHealth);
    }
    

}
