using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLaserGun : MonoBehaviour
{
    public Animator gunAnimator;
    public void FireGun()
    {
        //Access the animator on the gun model, trigger the
        gunAnimator.SetTrigger("Fire");

        Debug.Log("น฿ป็~");
    }
}
