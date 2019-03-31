using UnityEngine;

public class Weapon : MonoBehaviour //parent class for the rest of the weapons
{
    protected float projectileSpeed;
    public int damage;
    public float fireRate;
    protected Rigidbody rb;

    protected virtual void Awake() { }

    protected virtual void Start() { }

    protected virtual void Update() { }

    protected virtual void OnTriggerEnter() { }
}
