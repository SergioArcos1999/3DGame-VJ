using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class palaAvoid : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20.0f;
    public Rigidbody rb;
    float lastCollisionTime, actualCollisionTime;
    public Transform target;
    private Vector3 initPosition;
    void Start()
    {
        initPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if ((target.position.x > transform.position.x) && ((target.position.x - transform.position.x) <= 10))
        {
            Debug.Log("if");
            if (target.position.y > transform.position.y)
            {
                if (tag == "palaAvoid") speed = -20.0f;
                else speed = 20.0f;
            }
            else if (target.position.y < transform.position.y)
            {
                if (tag == "palaAvoid") speed = 20.0f;
                else speed = -20.0f;
            }
            else speed = -20.0f;
        }
        else
        {
            if (transform.position.y < initPosition.y) speed = 20.0f;
            //else if (transform.position.y > initPosition.y) speed = -20.0f;
            else speed = 0.0f;
        }
        rb.velocity = new Vector3(0.0f, speed, 0.0f);
        Debug.Log(rb.velocity);
    }
}
