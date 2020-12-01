using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public float speed = 15.0f;
    private Vector3 lastSpeed;
    public Rigidbody rb;
    float vx, vy, timeLastChange, lastCollisionTime;
    public GameObject efecto;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector3(speed, speed);
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
           Instantiate(efecto,
               new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z),
                   transform.rotation);
            timeLastChange = Time.time;
            rb.velocity = new Vector3(rb.velocity.x, -rb.velocity.y,0);
        }

       if (Input.GetKeyDown("p"))
       {
           transform.position = new Vector3 (-57.0f, 112.0f, -3.0f);
           rb.velocity = new Vector3(15.0f, 15.0f, 0);
       }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (Time.time - lastCollisionTime > 0.1) { 
            var direction = Vector3.Reflect(lastSpeed.normalized, collision.contacts[0].normal);
            if (direction.x > 0.0f && direction.y > 0.0f)
            {
                rb.velocity = new Vector3(15.0f, 15.0f, 0);
            }
            else if (direction.x > 0.0f && direction.y < 0.0f)
            {
                rb.velocity = new Vector3(15.0f, -15.0f, 0);
            }
            else if (direction.x < 0.0f && direction.y > 0.0f)
            {
                rb.velocity = new Vector3(-15.0f, 15.0f, 0);
            }
            else if (direction.x < 0.0f && direction.y < 0.0f)
            {
                rb.velocity = new Vector3(-15.0f, -15.0f, 0);
            }
            else
            {
                rb.velocity = new Vector3(15.0f, 15.0f, 0);
            }
            lastCollisionTime = Time.time;
                }
        Debug.Log(rb.velocity);
        //Debug.Log("Out Direction: " + direction);
    }

    void OnTriggerEnter(Collider trigger)
    {
        transform.Translate(-76.0f, 60.0f, 0, 0f);
    }
}
