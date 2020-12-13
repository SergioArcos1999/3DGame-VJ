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
        finalTime = 80f;
        destroyTime += 1;
        if (destroyTime  >= finalTime && touch == true) {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            destroyTime = 0f;
            audioSource.Play();
            touch = true;
        }
    }
}
