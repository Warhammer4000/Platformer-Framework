using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandeler : MonoBehaviour
{
    public enum BodyPart
    {
        Head,Chest,Arm,Legs
    }


    public BodyPart Part;
    public EnemyLogic EnemyLogic;

    void Start()
    {
      
    }

    public void DealDamage(int damage)
    {
        switch (Part)
        {
            case BodyPart.Head:
                EnemyLogic.Stats.HeadShot();
                break;
            case BodyPart.Chest:
                EnemyLogic.Stats.ApplyDamage(damage);
                break;
            case BodyPart.Arm:
                EnemyLogic.Stats.ApplyDamage((int) (damage*GlobalStats.ArmLegDamageReduction));
                break;
            case BodyPart.Legs:
                EnemyLogic.Stats.ApplyDamage((int)(damage * GlobalStats.ArmLegDamageReduction));
                break;
        }
    }
}
