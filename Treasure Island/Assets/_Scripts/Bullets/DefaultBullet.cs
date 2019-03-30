using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultBullet : AbstractBullet
{
    protected override void Awake() {
        rb = this.GetComponent<Rigidbody>();    
        speed = 10.0f;
        damage = 1;
    }

    protected override void Update() {
        rb.velocity = transform.forward * speed;
        Destroy(this.gameObject, 0.2f);
    }
}
