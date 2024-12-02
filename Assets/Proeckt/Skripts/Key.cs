using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    
    public void Take() 
    {
        //Password.onOpoen.Invoke();
        Destroy(gameObject);
    }
}
