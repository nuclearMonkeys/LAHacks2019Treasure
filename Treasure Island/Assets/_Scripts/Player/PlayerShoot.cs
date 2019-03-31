using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject knifePrefab;
    [SerializeField] private GameObject bulletSpawnPoint;
    [SerializeField] private GameManager gameManager;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float lookSpeed = 5.0f;

    public Ammo playerAmmo;
    public string currentWeapon;
    public Pistol playerPistol;
    public Knife playerKnife;
    public Rifle playerRifle;
    public Shotgun playerShotgun;
    public Bow playerBow;
    public Spear playerSpear;

    //possible weapons include "KNIFE", "PISTOL", "RIFLE", "SHOTGUN", "BOW", "SPEAR"

    // Start is called before the first frame update
    void Awake()
    {
        rb = this.GetComponent<Rigidbody>();
        gameManager = Object.FindObjectOfType<GameManager>();
        GameObject.FindGameObjectsWithTag("Player");
        currentWeapon = "PISTOL";
    }

    // Update is called once per frame
    void Update()
    {
        Look();
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && !Input.GetKey(KeyCode.LeftShift))
        {
            switch (currentWeapon)
            {
                case "KNIFE":
                    KnifeAttack();
                    break;
                case "PISTOL":
                    PistolAttack();
                    break;
                case "RIFLE":
                    RifleAttack();
                    break;
                case "SHOTGUN":
                    ShotgunAttack();
                    break;
                case "BOW":
                    BowAttack();
                    break;
                case "SPEAR":
                    SpearAttack();
                    break;
            }
        }
    }

    void KnifeAttack()
    {
        Instantiate(knifePrefab, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);
    }

    void PistolAttack()
    {
        if (playerAmmo.GetAmmoCount(currentWeapon) > 0)
        {
            playerAmmo.ConsumeAmmo(currentWeapon);
            Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);
        }
    }

    void RifleAttack()
    {
        if (playerAmmo.GetAmmoCount(currentWeapon) > 0)
        {
            playerAmmo.ConsumeAmmo(currentWeapon);
            Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);
        }
    }

    void ShotgunAttack()
    {
        if (playerAmmo.GetAmmoCount(currentWeapon) > 0)
        {
            playerAmmo.ConsumeAmmo(currentWeapon);
            Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, this.transform.rotation);
            Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, this.transform.rotation);
            Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, this.transform.rotation);
            Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, this.transform.rotation);
            Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, this.transform.rotation);
        }
    }

    void BowAttack()
    {
        if (playerAmmo.GetAmmoCount(currentWeapon) > 0)
        {
            playerAmmo.ConsumeAmmo(currentWeapon);
            //instantiate bow attack
        }
    }

    void SpearAttack()
    {
        if (playerAmmo.GetAmmoCount(currentWeapon) > 0)
        {
            playerAmmo.ConsumeAmmo(currentWeapon);
            //instantiate spear attack
        }
    }

    void Look()
    {
        Plane playerPlane = new Plane(Vector3.up, transform.position);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        float hitdist = 0.0f;

        if (playerPlane.Raycast(ray, out hitdist))
        {
            Vector3 targetPoint = ray.GetPoint(hitdist);

            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);

            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, lookSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EnemyBullet"))
        {
            gameManager.playerIsDead = true;
            Destroy(this.gameObject);
        }
    }
}