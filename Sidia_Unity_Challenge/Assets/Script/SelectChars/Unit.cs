using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public int damage = 20;

    public int maxHP = 100;
    public int currentHP = 100;



    public bool TakeDamage (int dmg)
    {

        currentHP -= dmg;
        if (currentHP <= 0)
        {
            return true;
        }
        else
            return false;
    }
}
