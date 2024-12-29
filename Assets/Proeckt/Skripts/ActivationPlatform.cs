using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationPlatform : MonoBehaviour

{

    public Platform platform;

    public void OnTarget()

    {
        platform.enabled = true;
        Quaternion.Lerp()
    }

}
