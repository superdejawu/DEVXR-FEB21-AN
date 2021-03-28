using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRSnapTurn : MonoBehaviour
{
    public Transform xrRig;
    private VRInput controller;

    public int angle = 20;
    void Awake()
    {
        controller = GetComponent<VRInput>();
    }


    // Update is called once per frame
    void Update()
    {
        if(controller.thumbstick.x > 0.9f)
        {
            xrRig.transform.Rotate(0f, angle, 0f, Space.World);
        }
        else if (controller.thumbstick.x < -0.9f)
        {
            xrRig.transform.Rotate(0f, -angle, 0f, Space.World);
        }
    }
}
