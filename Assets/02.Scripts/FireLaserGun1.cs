using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLaserGun1 : MonoBehaviour
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

        GetComponent<AudioSource>().Play();

        List<UnityEngine.XR.InputDevice> devices = new List<UnityEngine.XR.InputDevice>();

        
    }
}
