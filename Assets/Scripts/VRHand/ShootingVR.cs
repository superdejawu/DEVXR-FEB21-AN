using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingVR : GrabbableObjectVR
{
    public GameObject pelletPrefab;
    public float shootingForce;
    public Transform spawnPoint;

    public List<Material> paints = new List<Material>();
    public int paintIndex = 0;



    public override void OnInteractionStarted()
    {
        GameObject spawnedPellet = Instantiate(pelletPrefab, spawnPoint.position, spawnPoint.rotation);
        spawnedPellet.GetComponent<Rigidbody>().AddForce(spawnedPellet.transform.forward * shootingForce);
        Destroy(spawnedPellet, 2);



}
}
