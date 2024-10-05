using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraUp : MonoBehaviour
{
    public Camera cam;
    public Vector3 target;
    public static CameraUp rid { get; set; }
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
    public void Ontarget(Vector3 look) 
    {
        target = look;
        cam.enabled = true;
    }
    public void AndDemo() 
    {
        cam.enabled = false;
    }
    private void Update()
    {
        var looker = target - transform.position;
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(looker), Time.deltaTime);
    }
}
