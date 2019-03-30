using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; //target is what the camera will follow (usually player)
    public Vector3 offset = new Vector3 (0, 5, -4);
    void LateUpdate()
    {
        transform.position = target.TransformPoint(offset);
    }
}
