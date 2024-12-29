using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Animator anim;

    void OnTriggerEnter(Collider other)

    {
        if(other.gameObject.tag == "Player")
        {
            Animation();
        }
    }

    void Animation()

    {
        anim.SetFloat("Press" , 1);
    }

}
