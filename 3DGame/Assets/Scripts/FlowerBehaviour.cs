using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerBehaviour : MonoBehaviour
{
    public float minScale = 2f;
    public float maxScale = 2.5f;
    public float Speed = 0.5f;
    private Vector3 minScaleVector;
    private Vector3 maxScaleVector;
    private Vector3 SpeedVector;
    private bool suma = false;

    // Start is called before the first frame update
    void Start()
    {
        minScaleVector = new Vector3(minScale, 2.5f, 2.5f);
        maxScaleVector = new Vector3(maxScale, 2.5f, 2.5f);
        SpeedVector = new Vector3(Speed, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x <= minScale) suma = true;
        else if (transform.localScale.x >= maxScale) suma = false;

        if(suma)
        {
            transform.localScale += SpeedVector*Time.deltaTime;
        }
        else 
        {
            transform.localScale -= SpeedVector*Time.deltaTime;
        }
    }
}
