using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeTriggerZone : MonoBehaviour
{
    public Animator bridgeAnimator;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            bridgeAnimator.SetTrigger("Raise");
        }

    }

    private void OnTriggerStay(Collider other)
    {

    }

    private void OnTriggerExit(Collider other)
    {
        
    }

}
