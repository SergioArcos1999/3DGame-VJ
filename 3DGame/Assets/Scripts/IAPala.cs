using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAPala : MonoBehaviour
{
    public float speed = 15.0f;
    public Rigidbody rb;
    float lastCollisionTime, actualCollisionTime;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector3(0.0f, speed, 0.0f);
        lastCollisionTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x - target.position.x <= 10) {
            Debug.Log("Difference:" + (transform.position.x - target.position.x));
            if (target.position.y > transform.position.y)
            {
                speed = 15.0f;
            }
            else if (target.position.y < transform.position.y)
            {
                speed = -15.0f;
            }
            rb.velocity = new Vector3(0.0f, speed, 0.0f);
            actualCollisionTime = Time.time;
        }
        
    }
}
