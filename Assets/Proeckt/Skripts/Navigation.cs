using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navigation : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform target;
    public float speed, interval;
    public Animator anim;
    public float timer;
    public Vector3 onmuwe;

    public void Onpointer(Vector3 point) 
    {
        onmuwe = point;
        timer = interval;
    }
    public void Nokout()
    {
        
        if(target == null)
        {
            anim.SetBool("NokOyt", true);
            timer = interval * 3;
        }
        
    }
    public void Ontarget()
    {
        target = Muwer.rid.transform;
    }
    public void OffTarget()
    {
        target = null;
    }
    private void FixedUpdate()
    {
        anim.SetBool("Run" , !agent.isStopped);
        anim.SetFloat("Speed" , agent.velocity.magnitude/agent.height);
        if (target == null)
        {
            agent.speed = speed;
            agent.destination = onmuwe;
            
            if (timer > 0)
            {
                agent.isStopped = true;
                timer -= Time.deltaTime;
            }
            else
            {
                agent.isStopped = false;
                anim.SetBool("NokOyt", false);
            }
        }
        else 
        {
            agent.speed = speed * 2;
            agent.destination = target.position;
        }
    }
}
