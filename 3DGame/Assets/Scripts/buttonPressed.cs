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
        if (target != null) Destroy(target);
        if (target1 != null) Destroy(target1);
        if (target2 != null)Destroy(target2);
        if (target3 != null)Destroy(target3);
        if (target4 != null)Destroy(target4);
        if (target5 != null)Destroy(target5);
        if (target6 != null)Destroy(target6);
    }
}
