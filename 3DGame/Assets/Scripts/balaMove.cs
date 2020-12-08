using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balaMove : MonoBehaviour
{
    public Transform target;
    private float speed = 20.0f;

    private const float EPSILON = 0.1f;

    private Vector3 look;
    private Vector3 initPosition;
    // Start is called before the first frame update
    void Start()
    {
        initPosition = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

    void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.tag == "cpBala")
        {
            transform.position = trigger.gameObject.transform.position;
            transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
            trigger.gameObject.transform.position = initPosition;
        }
    }
}
