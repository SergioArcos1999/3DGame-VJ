using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalaMove : MonoBehaviour
{
    public float speed = 10.0f;
    public Rigidbody rb;
    private float lastCollisionTime;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector3(0.0f, speed, 0.0f);
        lastCollisionTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(0.0f, speed, 0.0f);
    }

    void OnCollisionEnter(Collision collision)
    {
        if ((collision.collider.tag == "limit") && (Time.time - lastCollisionTime > 0.1))
        {
            speed = -speed;
            lastCollisionTime = Time.time;
        }
    }
}