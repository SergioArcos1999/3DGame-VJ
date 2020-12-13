using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NubeBehaviour : MonoBehaviour
{
    private float minX, minY;
    public float maxX, maxY;

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
        if (maxY == transform.position.y)
        {
            transform.position = new Vector3(Mathf.PingPong(Time.time * 2, maxX - minX) + minX, transform.position.y, transform.position.z);
        }
        else if (maxX == transform.position.x)
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * 2, maxY - minY) + minY, transform.position.z);
        }
    }
}

