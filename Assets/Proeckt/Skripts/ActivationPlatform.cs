using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationPlatform : MonoBehaviour

{

    public Platform plat;
    public Transform platform;
    public Transform cam;
    float timer = 0;
    public void OnTarget()

    {
        cam.gameObject.SetActive(true);
        plat.enabled = true;
        timer = Time.time + 3;
    }
    private void FixedUpdate()
    {
        if (cam.gameObject.activeSelf) 
        {
            if (timer > Time.time)
            {
                Vector3 look = platform.position - cam.position;
                cam.rotation = Quaternion.Lerp(cam.rotation, Quaternion.LookRotation(look), 3 * Time.deltaTime);
            }
            else
            {
                cam.gameObject.SetActive(false);
            }
        }
        
        
    }
}
