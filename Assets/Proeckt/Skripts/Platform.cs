using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Vector3 nap;
    public float perriod, speed;
    public bool answer;
    private float time;

    private void Start()
    {
        time = Time.time + perriod;
    }
    void Update()
    {
        if (Time.time >= time) 
        {
            answer = !answer;
            Start();
        }
        if (answer)
        {
            transform.position += nap * speed * Time.deltaTime;
        }
        else 
        {
            transform.position -= nap * speed * Time.deltaTime;
        }
    }
}
