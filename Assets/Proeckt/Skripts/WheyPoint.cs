using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheyPoint : MonoBehaviour
{
    public Transform next;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy") 
        {
            other.GetComponent<Navigation>().Onpointer(next.transform.position);
        }
    }
}
