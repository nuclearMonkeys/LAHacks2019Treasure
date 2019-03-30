using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBehavior : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("PlayerBullet") || other.gameObject.CompareTag("EnemyBullet"))
        {
            Destroy(other.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerBullet") || other.CompareTag("EnemyBullet")) {
            Destroy(other.gameObject);
        }
    }
}
