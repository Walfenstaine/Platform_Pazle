using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TNT : MonoBehaviour
{
    public Animator anim;
    public MeshRenderer render;
    public GameObject drop;
    public static TNT rid { get; set; }
    void Awake()
    {
        if (rid == null)
        {
            rid = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void OnDestroy()
    {
        rid = null;
    }
    public void Kik()
    {
        if (render.enabled) 
        {
            anim.SetTrigger("Kik");
        }
    }
    public void Drop() 
    {
        Rigidbody rb = Instantiate(drop).GetComponent<Rigidbody>();
        rb.transform.position = transform.position;
        rb.AddForce(Camera.main.transform.forward * 420);
        rb.AddTorque(transform.right * 20);

       render.enabled = false;
    }
    public void Take()
    {
        render.enabled = true;
    }
}
