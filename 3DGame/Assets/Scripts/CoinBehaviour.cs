using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    public AudioSource audioSource;
    private float finalTime;
    private float destroyTime;
    private bool touch = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float delta = Time.deltaTime;
        
        transform.Rotate(0.0f, 40.0f * delta, 0.0f);
        
        
        finalTime = 65f;
        destroyTime += 1;
        if (destroyTime*delta  <= finalTime*delta && touch == true) {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.03f, transform.position.z);
            transform.Rotate(0.0f, 80.0f * delta*7, 0.0f);
            if(destroyTime == finalTime) Destroy(gameObject);
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !touch)
        {
            
            destroyTime = 0f;
            audioSource.Play();
            
            
            
            touch = true;
        }
    }
}
