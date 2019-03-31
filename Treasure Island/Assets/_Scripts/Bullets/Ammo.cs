using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public const int knifeAmmoCount = 1; //knife attacks do not consume ammo
    public int pistolAmmoCount = 25;
    public int rifleAmmoCount = 50;
    public int shotgunAmmoCount = 60;
    public int bowAmmoCount = 20;
    public int spearAmmoCount = 10;

   public int GetAmmoCount(string weaponKind)
    {
        switch (weaponKind)
        {
            case "KNIFE":
                return knifeAmmoCount;
            case "PISTOL":
               return pistolAmmoCount;
            case "RIFLE":
                return rifleAmmoCount;
            case "SHOTGUN":
               return shotgunAmmoCount;
            case "BOW":
                return bowAmmoCount;
            case "SPEAR":
                return spearAmmoCount;
            default:
                return 0;
        }
    }

   public void ConsumeAmmo(string weaponKind)
    {
        switch (weaponKind)
        {
            case "PISTOL":
                pistolAmmoCount--;
                break;
            case "RIFLE":
                rifleAmmoCount--;
                break;
            case "SHOTGUN":
                shotgunAmmoCount--;
                break;
            case "BOW":
                bowAmmoCount--;
                break;
            case "SPEAR":
                spearAmmoCount--;
                break;
        }
    }

   public void PickupAmmo(string weaponKind) //increase ammo when new weapon is picked up for the first time
    {
        switch (weaponKind)
        {
            case "PISTOL":
                pistolAmmoCount += 10;
                break;
            case "RIFLE":
                rifleAmmoCount += 15;
                break;
            case "SHOTGUN":
                shotgunAmmoCount += 8;
                break;
            case "BOW":
                bowAmmoCount += 8;
                break;
            case "SPEAR":
                spearAmmoCount += 4;
                break;
        }
    }
}
