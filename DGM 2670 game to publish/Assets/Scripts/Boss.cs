using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{

    public int health;
    public int damage;

    public Slider healthbar;

    private void Update()
    {
        healthbar.value = health;
    }
}
