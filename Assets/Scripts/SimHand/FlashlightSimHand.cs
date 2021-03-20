using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightSimHand : MonoBehaviour
{
    public Light flashLight;

    private GrabbableObjectSimHand grabbableObjectSimHand;

    // Start is called before the first frame update
    void Start()
    {
        grabbableObjectSimHand = GetComponent<GrabbableObjectSimHand>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(grabbableObjectSimHand.isBeingHeld)
        {

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Interact();
            }
          
        }
    }

    public void Interact()
    {
        flashLight.enabled = !flashLight.enabled;
    }
}
