using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRTeleportation : MonoBehaviour
{
    [Tooltip("This is the transform we want to teleport")]
    public Transform xrRig;

    private VRInput controller;
    private LineRenderer teleportLaser;
    private Vector3 hitPosition;

    public bool shouldTeleport = false;

    void Awake()
    {
        controller = GetComponent<VRInput>();
        teleportLaser = GetComponent<LineRenderer>();
        teleportLaser.enabled = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (controller.thumbstick.y > 0.8f)
        {
            //raycast needs: start, direction, out RaycastHit
            RaycastHit hit;
            if(Physics.Raycast(controller.transform.position, controller.transform.forward, out hit))
            {
                hitPosition = hit.point;
                teleportLaser.SetPosition(0, controller.transform.position);
                teleportLaser.SetPosition(1, hitPosition);
                teleportLaser.enabled = true;

                shouldTeleport = true;

            }
        }
        else if(controller.thumbstick.y < 0.8f)
        {
          if(shouldTeleport == true)
            {
                xrRig.transform.position = hitPosition;
            }
            teleportLaser.enabled = false;
        }
    }
}
