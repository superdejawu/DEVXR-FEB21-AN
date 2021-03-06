using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeTriggerZone : MonoBehaviour
{
    public Animator bridgeAnimator;
    private object detectBridgeRaise;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            bridgeAnimator.SetTrigger("Raise");
            bridgeAnimator.SetBool("isRaising", true);
            Debug.Log("isRaising: true");
        }

    }

    //private void OnTriggerStay(Collider other)
    //{
  
    //}

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            StartCoroutine(DetectBridgeRaise());
        }
    }

    private IEnumerator DetectBridgeRaise()
    {
        yield return new WaitForSeconds(3f);
        bridgeAnimator.SetBool("isRaising", false);
        Debug.Log("isRaising: false");
    }
}
