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
    private Vector3 initPosition;
    void Start()
    {
        initPosition = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
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
           Object a = Instantiate(efecto,
               new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z),
                   transform.rotation);
           Destroy(a, 2.0f);
           timeLastChange = Time.time;
            rb.velocity = new Vector3(rb.velocity.x, -rb.velocity.y,0);
        }

       if (Input.GetKeyDown("p"))
       {
           transform.position = initPosition;
           rb.velocity = new Vector3(15.0f, 15.0f, 0);
       }
       Debug.Log("preliminar"+rb.velocity);
       float x = 0, y = 0;
       if (rb.velocity.x < 0) x = -15.0f;
       if (rb.velocity.y < 0) y = -15.0f;
       if (rb.velocity.x >= 0) x = 15.0f;
       if (rb.velocity.y >= 0) y = 15.0f;
       rb.velocity = new Vector3(x,y,0.0f);
       Debug.Log("final"+rb.velocity);
    }

    void OnCollisionEnter(Collision collision)
    {
        if ((Time.time - lastCollisionTime > 0.1) && (collision.collider.tag != "noPlayer"))
        {
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
 
        Debug.Log("preliminar"+rb.velocity);
        float x = 0, y = 0;
        if (rb.velocity.x < 0) x = -15.0f;
        if (rb.velocity.y < 0) y = -15.0f;
        if (rb.velocity.x >= 0) x = 15.0f;
        if (rb.velocity.y >= 0) y = 15.0f;
        rb.velocity = new Vector3(x,y,0.0f);
        Debug.Log("final"+rb.velocity);


        //Debug.Log(rb.velocity);
        //Debug.Log("Out Direction: " + direction);
    }

    void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.tag == "tp" || trigger.gameObject.tag == "enemy") transform.position = initPosition;
        else if (trigger.gameObject.tag == "checkpoint")
        {
            initPosition = trigger.gameObject.transform.position;
        }
        else if (trigger.gameObject.tag == "tuberia")
        {
        }
    }
}
