using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public int paintIndex = 0;

public class ShootingVR : GrabbableObjectVR
{
    public GameObject pelletPrefab;
    public float shootingForce;
    public Transform spawnPoint;


    public override void OnInteraction()
    {
        GameObject spawnedPellet = Instantiate(pelletPrefab, spawnPoint.position, spawnPoint.rotation);
        spawnedPellet.GetComponent<Rigidbody>().AddForce(spawnedPellet.transform.forward * shootingForce);
        Destroy(spawnedPellet, 2);
    }
}
