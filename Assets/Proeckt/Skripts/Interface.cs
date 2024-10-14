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
    public void Sum(int index, bool cursor, float scale)
    {
        sumer[index].Invoke();
        CursorEvent(cursor);
        Time.timeScale = scale;
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
