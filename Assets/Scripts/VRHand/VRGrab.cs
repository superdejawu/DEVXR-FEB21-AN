using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRGrab : MonoBehaviour

//what we're touching
{
    public GameObject collidingObject;

    public GameObject heldObject;

    private VRInput controller;
    private bool gripHeld;

    private void OnTriggerEnter(Collider other)
    {
        collidingObject = other.gameObject;
    }

    private void OnTriggerExit(Collider other)
    {
        collidingObject = null;
    }

    // Start is called before the first frame update
    void Awake()
    {
        controller = GetComponent<VRInput>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.gripValue >0.5f && gripHeld == true)
        {
            if (collidingObject && collidingObject.GetComponent<Rigidbody>())
            {
                heldObject = collidingObject;
                Grab();
            }
        }
        if (controller.gripValue < 0.5f && gripHeld ==false)
        {
            if (heldObject)
            {
                Release();
            }
        }
    }
    public void Grab()
    {
        heldObject.transform.SetParent(this.transform);

        heldObject.GetComponent<Rigidbody>().isKinematic = true;
    }

    public void Release()
    {

        heldObject.transform.SetParent(null);

        heldObject.GetComponent<Rigidbody>().isKinematic = false;
    }

}
