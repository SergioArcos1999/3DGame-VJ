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
            //lose efect
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            --lives;
            //emetir sonido AAAARGH;
            collision.collider.transform.position = new Vector3(-61.0f,62.6f, -3.0f);
        }
    }
}
