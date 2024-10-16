using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 muve;
    public float timer;
    public float interval;

    void Start()

    {
        rb.isKinematic = true; 
        muve = transform.position;
    }

    void Update()

    {
        if(!rb.isKinematic)
        {
            timer += Time.deltaTime;
        }
        if(timer > interval)
        {
            transform.position = muve;
            rb.isKinematic = true;
            timer = 0;
        }
    }

    void OnTriggerEnter(Collider other)

    {
        if(other.gameObject.tag == "Player")
        {
            Invoke("Fall" , 1);
        }
    }

    void Fall()

    {
        rb.isKinematic = false;
    }

}
