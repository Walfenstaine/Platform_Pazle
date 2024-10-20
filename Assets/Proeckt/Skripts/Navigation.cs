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

    void Start()

    {
        
    }

    void Update()

    {
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
        }
    }

}
