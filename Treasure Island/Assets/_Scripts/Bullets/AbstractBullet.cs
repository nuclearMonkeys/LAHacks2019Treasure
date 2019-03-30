﻿using UnityEngine;

public class AbstractBullet : MonoBehaviour
{
    protected float speed;
    protected int damage;
    protected Rigidbody rb;

    protected virtual void Awake() { }

    protected virtual void Start() { }

    protected virtual void Update() { }

    protected virtual void OnTriggerEnter() { }
}