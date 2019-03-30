using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 7.0f;
    [SerializeField] private Rigidbody rb;

    // Start is called before the first frame update
    void Awake()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    void Move() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        rb.velocity = (transform.forward * vertical) * speed * Time.fixedDeltaTime;

        transform.Translate(new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime);

        //rb.AddForce(new Vector3(horizontal, 0.0f, vertical) * speed);
        rb.velocity = new Vector3(horizontal * 2, 0.0f, vertical * 2) * speed;
        //rb.MovePosition(transform.position + new Vector3(horizontal * 2, 0.0f, vertical * 2) * speed);
    }
}
