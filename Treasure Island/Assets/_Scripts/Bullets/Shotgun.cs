using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon
{
    protected override void Awake()
    {
        rb = this.GetComponent<Rigidbody>();
        projectileSpeed = 125.0f;
        damage = 2;
        fireRate = 1.5f;
    }

    protected override void Update()
    {
        rb.AddForce(transform.forward * projectileSpeed);
        Destroy(this.gameObject, 0.2f);
    }
}
