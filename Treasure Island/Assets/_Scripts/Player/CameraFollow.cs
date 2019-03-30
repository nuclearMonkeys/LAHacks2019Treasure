using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; //target is what the camera will follow
    public Vector3 offset; //camera offset so it's not at the exact same position as the target

    void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        offset = new Vector3(0, 5, -4);
    }

    void LateUpdate()
    {
        transform.position = target.TransformPoint(offset);
    }
}
