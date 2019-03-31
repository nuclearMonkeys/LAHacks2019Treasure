using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : Weapon
{
   const float fireRate = 3.0f;

    protected override void Awake()
    {
        projectileSpeed = 40.0f;
        damage = 10;
    }

    protected override void Update()
    {

    }
}
