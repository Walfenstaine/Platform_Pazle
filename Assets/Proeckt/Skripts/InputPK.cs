using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPK : MonoBehaviour
{
    public static InputPK rid { get; set; }
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
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Interface.rid.Sum(0);
        }
        if (Muwer.rid) 
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Muwer.rid.Jump();
            }
            Muwer.rid.muve.z = Input.GetAxis("Vertical");
            Muwer.rid.muve.x = Input.GetAxis("Horizontal");
            Muwer.rid.rut = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        }
    }
}
