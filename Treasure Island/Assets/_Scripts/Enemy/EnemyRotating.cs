using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotating : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(transform.rotation.x, transform.rotation.y + Time.deltaTime, transform.rotation.z);
    }
}
