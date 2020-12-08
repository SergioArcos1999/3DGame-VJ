using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalaMove : MonoBehaviour
{
    public float speed = 10.0f;
    public Rigidbody rb;
    private float lastCollisionTime;
	public AudioClip smash;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector3(0.0f, speed, 0.0f);
        lastCollisionTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
    	if (tag == "palaV") rb.velocity = new Vector3(0.0f, speed, 0.0f);
		else if (tag == "palaH") rb.velocity = new Vector3(speed, 0.0f, 0.0f);
    }

    void OnCollisionEnter(Collision collision)
    {
        if ((collision.collider.tag == "limit" || collision.collider.tag == "noPlayer" ) && (Time.time - lastCollisionTime > 0.1))
        {
			AudioSource.PlayClipAtPoint(smash, transform.position);
            speed = -speed;
            lastCollisionTime = Time.time;
        }
    }

	void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.tag == "noPlayer") {
            speed = -speed;
            lastCollisionTime = Time.time;
        }
    }
}