﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMove : MonoBehaviour
{
    public float speed = 15.0f;
    private Vector3 lastSpeed, lastCollisionSpeed;
    public Rigidbody rb;
    float vx, vy, timeLastChange, lastCollisionTime, lastTuberia;
    public GameObject efecto;
    private Vector3 initPosition;
    private bool godMode;
    public AudioSource changeDirectionSound;
    public AudioSource ballBounceSound;
    public AudioSource initSound;
    private Transform target1;
    private Transform target2;
    private bool insideTuberia;
    private bool arrivedFirstPoint;
    public AudioSource laught;
	public AudioSource tuberiaSound;
	public AudioSource death;
    void Start()
    {
        initPosition = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        rb.velocity = new Vector3(speed, speed);
		lastCollisionSpeed = rb.velocity;
        timeLastChange = Time.time;
        lastCollisionTime = Time.time;
        lastTuberia = Time.time;
        godMode = false;
        insideTuberia = false;
        arrivedFirstPoint = false;
        //AudioSource.PlayClipAtPoint(initSound, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if(!insideTuberia) {
       float timeFromPreviosChange = Time.time;
        lastSpeed = rb.velocity;
       if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && ((timeFromPreviosChange - timeLastChange) > 0.1))
       {
           changeDirectionSound.Play();
           Object a = Instantiate(efecto,
               new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z),
                   transform.rotation);
           Destroy(a, 2.0f);
           timeLastChange = Time.time;
            rb.velocity = new Vector3(rb.velocity.x, -rb.velocity.y,0);
        }

       if (Input.GetKeyDown("r"))
       {
           transform.position = initPosition;
           rb.velocity = new Vector3(15.0f, 15.0f, 0);
       }
       if (Input.GetKeyDown("g"))
       {
           if (!godMode) godMode = true;
           else godMode = false;
       }
       //Debug.Log("preliminar"+rb.velocity);
       float x = 0, y = 0;
       if (rb.velocity.x < 0) x = -15.0f;
       if (rb.velocity.y < 0) y = -15.0f;
       if (rb.velocity.x >= 0) x = 15.0f;
       if (rb.velocity.y >= 0) y = 15.0f;
       rb.velocity = new Vector3(x,y,0.0f);
       //Debug.Log("final"+rb.velocity);
    }
        else
        {
            if (target1 != null && target2 != null)
            {
                float step = speed * Time.deltaTime;
                if (!arrivedFirstPoint)
                {
                    transform.position = target1.position;
                    arrivedFirstPoint = true;
                }
                else transform.position = Vector3.MoveTowards(transform.position, target2.position, step);

                if (transform.position == target2.position)
                {
                    lastTuberia = Time.time;
                    insideTuberia = false;
                    arrivedFirstPoint = false;
                    Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y + 3.0f, transform.position.z), step);
                    tuberiaSound.Pause();
                }
            }
            
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if ((Time.time - lastCollisionTime > 0.1) && (collision.collider.tag != "noPlayer") && !insideTuberia)
        {
            ballBounceSound.Play();
            var direction = Vector3.Reflect(lastSpeed, collision.contacts[0].normal).normalized * Time.deltaTime * speed;
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
 
        //Debug.Log("preliminar"+rb.velocity);
        float x = 0, y = 0;
        if (rb.velocity.x < 0 && !insideTuberia) x = -15.0f;
        if (rb.velocity.y < 0 && !insideTuberia) y = -15.0f;
        if (rb.velocity.x >= 0 && !insideTuberia) x = 15.0f;
        if (rb.velocity.y >= 0 && !insideTuberia) y = 15.0f;
        rb.velocity = new Vector3(x,y,0.0f);
        //Debug.Log("final"+rb.velocity);


        //Debug.Log(rb.velocity);
        //Debug.Log("Out Direction: " + direction);
    }

    void OnTriggerEnter(Collider trigger)
    {
        if ((trigger.gameObject.tag == "enemy" && !godMode)) {
 			death.Play();
			transform.position = initPosition;
		}
        else if(trigger.gameObject.tag == "tp") { SceneManager.LoadScene("MiddleMenu"); }
        else if (trigger.gameObject.tag == "checkpoint")
        {
            initPosition = trigger.gameObject.transform.position;
        }
        else if (trigger.gameObject.tag == "cp1" && (Time.time - lastTuberia > 1.0f) && !insideTuberia)
        {
            insideTuberia = true;
            arrivedFirstPoint = false;
            target1 =  (GameObject.Find("Cp1")).transform;
            target2 =  (GameObject.Find("Cp2")).transform;
			tuberiaSound.Play();
        }
        else if (trigger.gameObject.tag == "cp2" && (Time.time - lastTuberia > 1.0f) && !insideTuberia)
        {
            insideTuberia = true;
            arrivedFirstPoint = false;
            target1 =  (GameObject.Find("Cp2")).transform;
            target2 =  (GameObject.Find("Cp1")).transform;
			tuberiaSound.Play();
        }
        else if (trigger.gameObject.tag == "bossTp")
        {
            transform.position = new Vector3(-60.0f, 74.0f, -3.0f);
			laught.Play();
			GetComponent<AudioSource>().Play();
            
        }
        else if (trigger.gameObject.tag == "trophy")
        {
            SceneManager.LoadScene("VictoryMenu");
        }
    }
}
