using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dor : MonoBehaviour
{
    public int password;
    public bool closed;
    public Animator anim;

    public void Opened(int number) 
    {
        if (number == password) 
        {
            closed = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (!closed) 
            {
                anim.SetBool("Open", true);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool("Open", false);
        }
    }
}
