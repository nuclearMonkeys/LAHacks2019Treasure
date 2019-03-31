using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : Weapon
{
    protected override void Awake()
    {
        projectileSpeed = 40.0f;
        damage = 10;
        fireRate = 5.0f;
    }

    protected override void Update()
    {

    }
}
