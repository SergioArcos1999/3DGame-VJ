using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitTierra : MonoBehaviour
{
    public GameObject bloqueTierraMario;
    // Start is called before the first frame update
    void Start()
    {
       for(int i = 0; i < 20; ++i)
        {
            GameObject obj = (GameObject)Instantiate(bloqueTierraMario, new Vector3(i * 3.0f - 27.0f, 35.0f, -12.0f), transform.rotation);
            obj.transform.parent = transform;
            obj = (GameObject)Instantiate(bloqueTierraMario, new Vector3(i * 3.0f -27.0f, 5.0f, -12.0f), transform.rotation);
            obj.transform.parent = transform;
        } 
       for(int i = 0; i < 10; ++i)
        {
            GameObject obj = (GameObject)Instantiate(bloqueTierraMario, new Vector3(-27.0f, i * 3.0f + 5.0f, -12.0f), transform.rotation);
            obj.transform.parent = transform;
            obj = (GameObject)Instantiate(bloqueTierraMario, new Vector3(30.0f, i * 3.0f + 5.0f, -12.0f), transform.rotation);
            obj.transform.parent = transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
