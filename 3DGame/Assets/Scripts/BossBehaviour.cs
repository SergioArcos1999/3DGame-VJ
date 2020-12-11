using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    private int lives;
    private float x0, y0;
    public float speedX = 20.0f;
    public float speedY = 5.0f;
    public GameObject aura;
    public Rigidbody rb;
    public GameObject d1;
    public GameObject d2;
    public GameObject d3;
    public GameObject d4;
    public GameObject d5;
    public GameObject l1;
    public GameObject l2;
    public GameObject l3;
	public AudioClip finalHit;
	public AudioClip hit;
    
    
    void Start()
    {
        lives = 3;
        x0 = transform.position.x;
        y0 = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (lives == 3) transform.position = new Vector3(transform.position.x, y0+5*Mathf.Sin(speedY*Time.time), transform.position.z);
        else if (lives == 2) transform.position = new Vector3(x0+1*Mathf.Sin(speedX*Time.time), y0+5*Mathf.Sin(speedY*Time.time), transform.position.z);
        else if (lives == 1) transform.position = new Vector3(x0+2*Mathf.Sin(speedX*2*Time.time), y0+5*Mathf.Sin(speedY*Time.time), transform.position.z);
        else
        {
            Destroy(aura);
            //lose efect
            GetComponent<BoxCollider>().enabled = false;
            float delta = Time.deltaTime;
            transform.Rotate(500.0f * delta, 0.0f, 0.0f);
            rb.velocity = new Vector3(30.0f, 30.0f, 0.0f);
            Destroy(d1);
            Destroy(d2);
            Destroy(d3);
            Destroy(d4);
            Destroy(d5);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            --lives;
            if (lives == 2) {
 				Destroy(l1);
				AudioSource.PlayClipAtPoint(hit, (GameObject.Find("Main Camera")).transform.position);
			}
            if (lives == 1) {
 				Destroy(l2);
				AudioSource.PlayClipAtPoint(hit, (GameObject.Find("Main Camera")).transform.position);
			}
            if (lives == 0) {
 				Destroy(l3);
            AudioSource.PlayClipAtPoint(finalHit, (GameObject.Find("Main Camera")).transform.position);
			}
            if (lives > 0) collision.collider.transform.position = new Vector3(-61.0f,62.6f, -3.0f);
        }
    }
}
