using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killGoomba : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject deadGoomba; 
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnCollisionEnter(Collision collision)
    {
        Instantiate(deadGoomba, new Vector3 (this.transform.position.x, this.transform.position.y, this.transform.position.z),new Quaternion(0.0f, -180.0f , 0.0f, 1));
        transform.position = new Vector3 (-1000.0f, 0.0f, 0.0f);
    }
}
