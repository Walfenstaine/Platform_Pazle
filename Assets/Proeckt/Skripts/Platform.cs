using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Rigidbody rb;

    void Start()

    {
        rb.isKinematic = true;
    }

    void Update()

    {
        
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
