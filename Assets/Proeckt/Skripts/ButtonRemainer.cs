using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRemainer : MonoBehaviour
{
    public int sum;
    public bool cursor;
    public float scale;

    public void OnClick()
    {
        Interface.rid.Sum(sum, cursor, scale);
        Muwer.rid.muve = Vector3.zero;
        Muwer.rid.rut = Vector2.zero;
    }
}
