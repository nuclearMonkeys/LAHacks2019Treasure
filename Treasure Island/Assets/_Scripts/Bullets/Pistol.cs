using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{

    protected override void Awake()
    {
        rb = this.GetComponent<Rigidbody>();
        projectileSpeed = 150.0f;
        damage = 3;
        fireRate = 1.0f;
    }

    protected override void Update()
    {
        rb.AddForce(transform.forward * projectileSpeed);
        Destroy(this.gameObject, 0.2f);
    }
}
