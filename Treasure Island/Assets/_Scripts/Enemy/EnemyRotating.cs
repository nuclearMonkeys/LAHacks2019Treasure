using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotating : MonoBehaviour
{
    public float speed;
    public float seconds = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (seconds <= 2.0f)
        {
            transform.Rotate(Vector3.up, speed * Time.deltaTime);
            seconds += Time.deltaTime;
        }
        else if (seconds >= 2.0f)
        {
            transform.Rotate(Vector3.up, 0 * Time.deltaTime);
            seconds += Time.deltaTime;
            if (seconds >= 4.0f)
            {
                seconds = 0.0f;
            }
        }


    }
}
