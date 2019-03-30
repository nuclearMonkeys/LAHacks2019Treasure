using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject bulletSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();   
    }

    void Shoot() {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, this.transform.rotation);
        }
    }
}
