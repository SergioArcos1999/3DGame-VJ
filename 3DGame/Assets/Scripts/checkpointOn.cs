using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointOn : MonoBehaviour
{
    public GameObject flagOn; 
    public GameObject efecto;
private bool catched;
    // Start is called before the first frame update
    void Start()
    {
       catched = false; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider trigger)
    {
		if (!catched) {
        	Instantiate(flagOn, new Vector3 (this.transform.position.x, this.transform.position.y, this.transform.position.z),new Quaternion(0.0f, -180.0f , 0.0f, 1));
        	//transform.position = new Vector3 (-1000.0f, 0.0f, 0.0f);
        	Object a = Instantiate(efecto,
            	new Vector3(this.transform.position.x, this.transform.position.y + 6.0f, this.transform.position.z),
            	transform.rotation);
			catched = true;
       		Destroy(a, 2.0f);
		}
    }
    
}
