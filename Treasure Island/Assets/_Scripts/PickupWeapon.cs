using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupWeapon : MonoBehaviour
{
    public string weaponName;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                // Pick up item

                other.GetComponent<PlayerShoot>().currentWeapon = weaponName;
            }
        }
    }
}
