using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balaMove : MonoBehaviour
{
    public Transform target;
    private float speed = 10.0f;

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
        look = (target.position - transform.position).normalized;

        if ((transform.position - target.position).magnitude < 40)
        {
            //transform.rotation = Quaternion.LookRotation(target.transform.position - transform.position);
            transform.Translate(look * Time.deltaTime * speed);
            
        }
            
        else  transform.position = initPosition;
    }

    void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.tag == "Player")
        {
            transform.position = initPosition;
        }
    }
}
