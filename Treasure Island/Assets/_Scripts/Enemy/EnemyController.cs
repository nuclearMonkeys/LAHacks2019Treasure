﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody myRB;
    public float moveSpeed;
    public float playerDistance;
    public float rotationDamping;
    public FollowPath path;
    public PlayerController thePlayer;
    public float seconds = 5.0f;
    public bool distance;
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody>();
        thePlayer = FindObjectOfType<PlayerController>();
        path = FindObjectOfType<FollowPath>();
    }

    void FixedUpdate()
    {
        myRB.velocity = (transform.forward * moveSpeed);
    }
    // Update is called once per frame
    void Update()
    {
        
        playerDistance = Vector3.Distance(thePlayer.position, transform.position);

        if (playerDistance < 5f)
        {
            distance = true;
            moveSpeed = 7.0f;
        }

        if (distance)
        {
            //transform.LookAt(thePlayer.transform.position);
            path.enabled = false;
            
            if (moveSpeed > 5.0f)
                moveSpeed -= 0.025f;

            else if (moveSpeed <= 5.0f)
            {
                distance = false;
             }
            rotationDamping = 5;
            lookAtPlayer();
        }
        else
        {
            moveSpeed = 0;
            rotationDamping = 0;
            distance = false;
            path.enabled = true;
          
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("PlayerBullet"))
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Wall")
        {
            transform.RotateAround(transform.position, transform.up, 180f);
        }
    }

    void lookAtPlayer()
    {
        Quaternion rotation = Quaternion.LookRotation(thePlayer.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationDamping);
    }

}