using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
     const float fireRate = 0.75f;

    protected override void Awake()
    {
        rb = this.GetComponent<Rigidbody>();
        projectileSpeed = 150.0f;
        damage = 3;
    }

    protected override void Update()
    {
        rb.AddForce(transform.forward * projectileSpeed);
        Destroy(this.gameObject, 0.2f);
    }
}
