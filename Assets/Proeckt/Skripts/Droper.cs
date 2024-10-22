using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droper : MonoBehaviour
{
    public GameObject tnt;
    public Rigidbody rb;
    private bool active = true;
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag != "Player"&& collision.gameObject.tag != "TNT") 
        {
            if (active)
            {
                active = false;
                Destroy(gameObject);
                Instantiate(tnt, transform.position, transform.rotation);
            }
            
            
        }
    }
}
