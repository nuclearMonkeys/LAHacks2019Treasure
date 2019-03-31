using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : Weapon
{
    float counter;
    bool endReached;
    Vector3 startPos;

    protected override void Start()
    {
        projectileSpeed = 5.0f;
        damage = 5;
        fireRate = 2.0f;
        counter = 0;
        endReached = false;
        startPos = transform.position;
    }

    protected override void Update()
    {
        if (endReached)
            Destroy(this.gameObject);


        Vector3 pos = new Vector3(
            startPos.x + Mathf.Sin(Mathf.PI * 2 * counter / 360),
            startPos.y,
            startPos.z + Mathf.Sin(Mathf.PI * 2 * counter / 360)
            );

        transform.position = Vector3.Lerp(transform.position, pos, 1f);

        counter += projectileSpeed;

        if (counter >= 180)
            endReached = true;
    }
}
