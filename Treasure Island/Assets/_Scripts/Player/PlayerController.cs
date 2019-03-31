using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    private Rigidbody myRigidbody;
    public Vector3 position;

    private Vector3 moveInput;
    private Vector3 moveVelocity;

        // Start is called before the first frame update
        void Start()
        {
            myRigidbody = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {

            //probably not gonna use this
        }

        //FixedUpdate is called at constant time intervals (as opposed to every frame, which can vary by machine)
        void FixedUpdate()
        {
        	position = transform.position;
    	    myRigidbody.velocity = moveVelocity;
            Move();
        }

        void Move()
        {
            if (!Input.GetKey(KeyCode.LeftShift))
                {
                moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
                moveVelocity = moveInput * moveSpeed * Time.fixedDeltaTime;
                transform.Translate(moveVelocity);
                 }
            else
            {
                //do nothing
            }
            moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
            moveVelocity = moveInput * moveSpeed * Time.fixedDeltaTime;
            transform.Translate(moveVelocity);
		}

}
