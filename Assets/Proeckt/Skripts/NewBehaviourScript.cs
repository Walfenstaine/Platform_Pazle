using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    void Start()

    {
        
    }

    void OnTriggerEnter(Collider other)

    {
        if(other.gameObject.tag == "Player")
        {
            Interface.rid.Sum(2 , true , 0);
        }
    }

}
