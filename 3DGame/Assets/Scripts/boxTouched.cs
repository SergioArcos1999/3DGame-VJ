using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxTouched : MonoBehaviour
{
    public GameObject coin;
    private bool touched;

    public Rigidbody rbCoin;
    // Start is called before the first frame update
    void Start()
    {
        touched = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player" && !touched)
        {
            touched = true;
            Object a = Instantiate(coin,
                new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z),
                transform.rotation);
            rbCoin.velocity = new Vector3(0.0f, 20.0f, 0.0f);
            float delta = Time.deltaTime;
            transform.Rotate(0.0f, 200.0f * delta, 0.0f);
            //Destroy(a, 5.0f);

        }
    }
}
