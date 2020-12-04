using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPressed : MonoBehaviour
{
    public GameObject target;
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    public GameObject target4;
    public GameObject target5;
    public GameObject target6;
    public GameObject after; 
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider trigger)
    {
        
        Instantiate(after, new Vector3 (this.transform.position.x, this.transform.position.y, this.transform.position.z),transform.rotation);
        transform.position = new Vector3 (-1000.0f, 0.0f, 0.0f);
        Destroy(target);
        Destroy(target1);
        Destroy(target2);
        Destroy(target3);
        Destroy(target4);
        Destroy(target5);
        Destroy(target6);
    }
}
