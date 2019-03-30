using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject bulletSpawnPoint;

    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Look();
        Shoot();   
    }

    void Shoot() {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            StartCoroutine(_DefaultShoot());
        }
    }

    IEnumerator _DefaultShoot() {
        Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);
        yield return new WaitForSeconds(.2f);
    }

    IEnumerator _ShotgunShoot() {
        Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, this.transform.rotation);
        Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, this.transform.rotation);
        Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, this.transform.rotation);
        yield return new WaitForSeconds(.2f);
    }

    void Look() {
        Plane playerPlane = new Plane(Vector3.up, transform.position);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        float hitdist = 0.0f;

        if (playerPlane.Raycast(ray, out hitdist)) {
            Vector3 targetPoint = ray.GetPoint(hitdist);

            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);

            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.deltaTime);
        }
    }
}
