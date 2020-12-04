using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointOn : MonoBehaviour
{
    public GameObject flagOn; 
    public GameObject efecto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider trigger)
    {
        Instantiate(flagOn, new Vector3 (this.transform.position.x, this.transform.position.y, this.transform.position.z),new Quaternion(0.0f, -180.0f , 0.0f, 1));
        //transform.position = new Vector3 (-1000.0f, 0.0f, 0.0f);
        Object a = Instantiate(efecto,
            new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z),
            transform.rotation);
        Destroy(a, 2.0f);
    }
    
}
