using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintballPellet : MonoBehaviour
{
    public Material paint;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Paintable") 
        {
            collision.collider.GetComponent<Renderer>().material = paint;
            Destroy(this.gameObject);
        }
    }
}
