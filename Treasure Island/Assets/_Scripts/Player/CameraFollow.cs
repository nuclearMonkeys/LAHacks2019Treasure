using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; //target is what the camera will follow
    public Vector3 offset; //camera offset so it's not at the exact same position as the target

    public float freeCameraSpeed; //speed that the cursor moves the camera when the player holds LShift
    public float freeCameraLimit;

    void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        offset = new Vector3(0, 5, -4);
        freeCameraSpeed = 0.5f;
        freeCameraLimit = 8.0f;
    }

    void FixedUpdate()
    {
        Vector3 mouseInput = new Vector3(Input.GetAxis("Mouse X"), 0, Input.GetAxis("Mouse Y"));

        if (Input.GetKey(KeyCode.LeftShift) && IsWithinLimit()) //holding shift, camera within free camera limit from player
        {
            //moves camera with mouse input
            transform.position += freeCameraSpeed * mouseInput;
        
        }
        else if (Input.GetKey(KeyCode.LeftShift) && !IsWithinLimit()) //holding shift, camera at free camera limit from player
        {
            //moves camera only if input reduces distane between camera and player
            if (Vector3.Distance( (transform.position + freeCameraSpeed * mouseInput), target.position) < Vector3.Distance(transform.position, target.position) )
            {
                transform.position += freeCameraSpeed * mouseInput;
            }
        }
        else //not holding shift, camera will follow player
        {
            transform.position = target.TransformPoint(offset);
        }
    }

    bool IsWithinLimit() //checks if camera is within the free camera limit
    {
        float cameraDistance = Vector3.Distance(transform.position, target.position);

        if (cameraDistance < freeCameraLimit)
            return true;
        else
            return false;
    }
}

