using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyLogic : MonoBehaviour
{
    public Stats Stats;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void EnemyBegin()
    {
        EnemyAction();
    }

    protected abstract void EnemyAction();



}
