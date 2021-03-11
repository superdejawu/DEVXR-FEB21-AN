using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRHandAnimator : MonoBehaviour
{
    // Start is called before the first frame update
    private VRInput controller;
    private Animator handAnimator;

    void Awake()
    {
        controller = GetComponent<VRInput>();
        handAnimator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(controller)
        {
            handAnimator.Play("Fist Closing", 0, controller.gripValue);
        }
    }
}
