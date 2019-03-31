﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : Weapon
{
    protected override void Awake()
    {
        projectileSpeed = 100.0f;
        damage = 5;
        fireRate = 4f;
    }

    protected override void Update()
    {

    }
}
