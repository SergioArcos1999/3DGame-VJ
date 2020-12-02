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
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider trigger)
    {
        Destroy(target);
        Destroy(target1);
        Destroy(target2);
        Destroy(target3);
        Destroy(target4);
        Destroy(target5);
        Destroy(target6);
    }
}
