using Autodesk.Fbx;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class TreeggerButton : MonoBehaviour
{
    public UnityEvent clic;
    public Animator anim;
    public int num;

    public void Onstarter() 
    {
        anim.SetBool("Get",true);
        CameraUp.rid.Ontarget(transform.position);
    }
    public void AndAnim() 
    {
        anim.SetBool("Set", false);
        anim.SetBool("Get", false);
    }

    public void Onget()
    {
        clic.Invoke();
        GrandPanel.rid.Ensept(num);
    }
    public void Onset()
    {
        GrandPanel.rid.Extsept(num);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            CameraUp.rid.Ontarget(transform.position);
            anim.SetBool("Set", true);
        }
    }

}
