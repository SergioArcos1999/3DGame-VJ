using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsectBehaviour : MonoBehaviour
{
    private float minX, minY;
    public float maxX, maxY;

    private Vector3 RotationX = new Vector3(0f, 180, 0);
    private Vector3 RotationY = new Vector3(180, 0, 0);

    void Start()
    { 
        minX = transform.position.x;
        minY = transform.position.y;
        maxX = transform.position.x + maxX;
        maxY = transform.position.y + maxY;
    }

    // Update is called once per frame
    void Update()
    {
        float delta = Time.deltaTime;
        
        if(maxY == transform.position.y)
        {
            transform.position = new Vector3(Mathf.PingPong(Time.time * 2, maxX - minX) + minX, transform.position.y, transform.position.z);
            if(transform.position.x <= minX + 0.5 || transform.position.x >= maxX - 0.5) transform.Rotate(0f, 360f * delta, 0f);
        }
        else if(maxX == transform.position.x)
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * 2, maxY - minY) + minY, transform.position.z);
            if (transform.position.y <= minY + 0.5 || transform.position.y >= maxY - 0.5) transform.Rotate(0f, 360f * delta, 0f);
        }
        
    }
}
