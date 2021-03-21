using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Base class for grabbable objects
/// </summary>
public class GrabbableObjectVR : MonoBehaviour
{
    public VRInput VRController;
    public bool isBeingHeld = false;

    public virtual void OnInteraction()
    {

    }
    
}
