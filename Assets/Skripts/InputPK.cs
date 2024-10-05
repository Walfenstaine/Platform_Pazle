using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPK : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Interface.rid.Sum(0);
        }
        if (Muwer.rid) 
        {
            Muwer.rid.muve.z = Input.GetAxis("Vertical");
            Muwer.rid.muve.x = Input.GetAxis("Horizontal");
            Muwer.rid.rut = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        }
    }
}
