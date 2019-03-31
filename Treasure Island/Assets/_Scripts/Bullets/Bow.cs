using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : Weapon
{
    const float fireRate = 2.0f;

    protected override void Awake()
    {
        projectileSpeed = 100.0f;
        damage = 5;
    }

    protected override void Update()
    {

    }
}
