using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 1;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerBullet")) {
            health -= other.gameObject.GetComponent<AbstractBullet>().damage;
        }
    }
}
