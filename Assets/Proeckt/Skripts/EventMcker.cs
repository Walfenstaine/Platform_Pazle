using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventMcker : MonoBehaviour
{
    public UnityEvent[] click;
    public void Click() 
    {
        click[0].Invoke();
    }
    public void Huck()
    {
        click[1].Invoke();
    }
}
