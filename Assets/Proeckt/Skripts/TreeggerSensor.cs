using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using YG;

public class TreeggerSensor : MonoBehaviour
{
    public UnityEvent click;

    private bool ontarget;
    private void FixedUpdate()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            click.Invoke();
        }
    }
}
