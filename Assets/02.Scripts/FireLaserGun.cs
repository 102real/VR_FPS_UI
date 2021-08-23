using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLaserGun : MonoBehaviour
{
    public Animator gunAnimator;
    public GameObject LaserBeamModel;
    public Transform LaserSpawnPoint;
    public void FireGun()
    {
        //Access the animator on the gun model, trigger the
        gunAnimator.SetTrigger("Fire");

        GameObject generatedLaserBeam = Instantiate(LaserBeamModel, LaserSpawnPoint.position, LaserSpawnPoint.rotation);

        Debug.Log("น฿ป็~");
    }
}
