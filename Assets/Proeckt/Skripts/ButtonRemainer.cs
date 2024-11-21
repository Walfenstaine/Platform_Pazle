using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRemainer : MonoBehaviour
{
    public Dor dor;
    public int sum, password;
    public bool cursor;
    public float scale;

    private void Awake()
    {
        if (dor != null) 
        {
            password = dor.password;
        }
       
    }
    public void OnClick()
    {
        Password.rid.Remain(password);
        Interface.rid.Sum(sum, cursor, scale);
        Muwer.rid.muve = Vector3.zero;
        Muwer.rid.rut = Vector2.zero;
    }
    public void Off() 
    {
        Password.rid.Remain(0);
    }
}
