using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Passworder : MonoBehaviour
{
    public float maine = 30;
    public UnityEvent click;
    public bool ontgregger;

    private void FixedUpdate()
    {
        if (ontgregger) 
        {
            var looker = transform.position - Camera.main.transform.position;
            float cutOf = Quaternion.Angle(Camera.main.transform.rotation, Quaternion.LookRotation(looker));
            if (cutOf < maine) 
            {
                click.Invoke();
                ontgregger = false;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ontgregger = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ontgregger = false;
        }
    }
}
