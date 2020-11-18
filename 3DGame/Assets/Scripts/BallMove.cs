using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public float speed = 15.0f;
    private Vector3 lastSpeed;
    public Rigidbody rb;
    float vx, vy, timeLastChange, lastCollisionTime;
    // Start is called before the first frame update
    void Start()
    {
        vx = 1.0f;
        vy = 1.0f;
        rb.velocity = new Vector3(speed * vx, speed * vy);
        timeLastChange = Time.time;
        lastCollisionTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
       float timeFromPreviosChange = Time.time;
        lastSpeed = rb.velocity;
       if (Input.GetKeyDown(KeyCode.Space) && ((timeFromPreviosChange - timeLastChange) > 0.1))
        {
            timeLastChange = Time.time;
            rb.velocity = new Vector3(rb.velocity.x, -rb.velocity.y,0);
        } 
    }

    void OnCollisionEnter(Collision collision)
    {
        if (Time.time - lastCollisionTime > 0.1) { 
            var direction = Vector3.Reflect(lastSpeed.normalized, collision.contacts[0].normal);
            if (direction.x > 0.0f && direction.y > 0.0f) rb.velocity = new Vector3(15.0f, 15.0f, 0);
            else if (direction.x > 0.0f && direction.y < 0.0f) rb.velocity = new Vector3(15.0f, -15.0f, 0);
            else if (direction.x < 0.0f && direction.y > 0.0f) rb.velocity = new Vector3(-15.0f, 15.0f, 0);
            else if (direction.x < 0.0f && direction.y < 0.0f) rb.velocity = new Vector3(-15.0f, -15.0f, 0);
            lastCollisionTime = Time.time;
                }
        //Debug.Log("Out Direction: " + direction);
    }
}
