using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navigation : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform[] target;
    public float speed;
    public float attackDistance;
    public Animator anim;
    public int num;
    public float timer;

    


    void Start()

    {
        
    }

    void Update()

    {
        if(transform == null)
        {
            if(timer > 0)
            {
                timer -= Time.deltaTime;
                agent.speed = 0;
                anim.SetBool("Run" , false);
            }
            anim.SetBool("Run" , true);
            anim.SetFloat("Speed" , agent.velocity.magnitude);
            agent.destination = target[num].position;
            agent.speed = speed;
            if(agent.remainingDistance <= attackDistance)
            {
                if(num < target.Length - 1)
                {
                    num += 1;
                }
                else
                {
                    num = 0;
                }
                timer = Random.Range(3 , 7);
            }
        }
        else
        {

        }
        
    }

}
