using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockPinchosMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float delta = Time.deltaTime;
        transform.Rotate(0.0f, 40.0f * delta, 0.0f);
    }
}
