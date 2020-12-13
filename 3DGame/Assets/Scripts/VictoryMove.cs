using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryMove : MonoBehaviour
{
    private float minX = 0, minY;
    public float maxX = 0, maxY;
 
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
            transform.position = new Vector3(Mathf.PingPong(Time.time * 100, maxX - minX) + minX, Mathf.PingPong(Time.time * 100, maxY - minY) + minY, transform.position.z);
            transform.Rotate(0f, 0f, 180f * delta);
    }
}
