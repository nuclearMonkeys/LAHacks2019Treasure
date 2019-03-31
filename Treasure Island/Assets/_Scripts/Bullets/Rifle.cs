using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Weapon
{
    const float fireRate = 0.1f;

    protected override void Awake()
    {
        rb = this.GetComponent<Rigidbody>();
        projectileSpeed = 175.0f;
        damage = 1;
    }

    protected override void Update()
    {
        rb.AddForce(transform.forward * projectileSpeed);
        Destroy(this.gameObject, 0.2f);
    }
}
