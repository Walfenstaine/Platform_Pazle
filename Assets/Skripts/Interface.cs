using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;

public class Interface : MonoBehaviour
{
    public UnityEvent[] sumer;
    public static Interface rid { get; set; }
    void Awake()
    {
        if (rid == null)
        {
            rid = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void OnDestroy()
    {
        rid = null;
    }

    void Start()
    {
        sumer[0].Invoke();
    }
    public void Sum(int index)
    {
        sumer[index].Invoke();
        if (index == 1)
        {
            CursorEvent(false);
            Time.timeScale = 1;
        }
        else 
        {
            CursorEvent(true);
            Time.timeScale = 0;
        }
    }
   
    void CursorEvent(bool activ)
    {
        if (activ)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        Cursor.visible = activ;
    }
}
