using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeggerButton : MonoBehaviour
{
    public TreeggerButton buton;
    public int number;
    public Animator anim;

    public void Onstarter() 
    {
        anim.SetBool("Play",true);
        CameraUp.rid.Ontarget(transform.position);
    }

    public void Insert() 
    {
        if (GetComponent<BoxCollider>())
        {
            GrandPanel.rid.Ensept(number);
        }
        else
        {
            anim.SetFloat("Speed", 0);
        }
    }
    public void AndAnim() 
    {
        if (GetComponent<BoxCollider>()) 
        {
            if (buton != null)
            {
                buton.Onstarter();
            }
            else
            {
                CameraUp.rid.AndDemo();
            }
        }
        
        anim.SetBool("Play", false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            if (GrandPanel.rid.keys[0] == number)
            {
                if (GrandPanel.rid.keys.Count == 1)
                {
                    Interface.rid.Sum(2);
                }
                anim.SetBool("Play", true);
                GrandPanel.rid.keys.RemoveAt(0);
                Destroy(GetComponent<BoxCollider>());
            }
            else 
            {
                Interface.rid.Sum(3);
            }
        }
    }

}
