using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Drops
{
    public GameObject thisDrop;
    public int dropChance;
}


[CreateAssetMenu]
public class LootTable : ScriptableObject
{
    public Drops[] drops;

    public GameObject GetPowerup()
    {
        int totalProb = 0;
        int currentProb = Random.Range(0, 100);
        for (int i = 0; i < drops.Length; i++)
        {
            totalProb += drops[i].dropChance;
            if (currentProb <= totalProb)
            {
                return drops[i].thisDrop;
            }
        }

        return null;
    }
}
