using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_MovingPlatform : MonoBehaviour
{
    public Platform activePlatform;
    public CharacterController controller;
    Vector3 moveDirection;

    void Update()
    {
        if (activePlatform != null)
        {
            moveDirection = activePlatform.muve;
            if (moveDirection.magnitude > 0.01f)
            {
                controller.Move(moveDirection);
            }
        }
        else
        {
            if (moveDirection.magnitude > 0.01f)
            {
                moveDirection = Vector3.Lerp(moveDirection, Vector3.zero, Time.deltaTime);
                controller.Move(moveDirection);
            }
        }
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.moveDirection.y < -0.9 && hit.normal.y > 0.41)
        {
            if (activePlatform != hit.collider.transform)
            {
                if (hit.collider.tag == "Grund")
                {
                    activePlatform = hit.collider.GetComponent<Platform>();
                }
                else 
                {
                    activePlatform = null;
                }
            }
        }
        else
        {
            activePlatform = null;
        }
    }
}
