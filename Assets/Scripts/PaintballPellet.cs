using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintballPellet : MonoBehaviour
{
    public ShootingVR controller;


    public List<Material> paints = new List<Material>();
    public static int paintIndex = 0;


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "Paintable") 
        {
            collision.collider.GetComponent<Renderer>().material = paints[paintIndex];
            paintIndex++;
            if(paintIndex == paints.Count)
            {
                paintIndex = 0;
            }
            //debug.log(controller.paintindex);

            Destroy(this.gameObject);
        }

    }

    private void Awake()
    {
        controller = GetComponent<ShootingVR>();
    }
}
