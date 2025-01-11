using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationPlatform : MonoBehaviour

{

    public Platform plat;
    public Transform platform;
    public Transform camera;

    public void OnTarget()

    {
        plat.enabled = true;
        Vector3 look = platform.position - camera.position;
        camera.rotation = Quaternion.Lerp(camera.rotation , Quaternion.LookRotation(look) , 3 * Time.deltaTime);
    }

}
