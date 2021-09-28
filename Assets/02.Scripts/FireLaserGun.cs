using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FireLaserGun : MonoBehaviour
{
    public Animator gunAnimator;
    public GameObject LaserBeamModel;
    public Transform LaserSpawnPoint;

    public static int bulletMasterR = 10;
    public TextMeshProUGUI countTR1;
    public TextMeshProUGUI countTR2;
    public TextMeshProUGUI countTR3;
    public TextMeshProUGUI countTR4;

    public AudioSource fire;
    public AudioSource erro;
    public AudioSource reload;

    private void Start()
    {
        countTR1.text = bulletMasterR + "/10";
        countTR2.text = bulletMasterR + "/10";
        countTR3.text = " "+bulletMasterR +" ";
        countTR4.text = " "+bulletMasterR +" ";
    }

    private void Update()
    {
        countTR1.text = bulletMasterR + "/10";
        countTR2.text = bulletMasterR + "/10";
        countTR3.text = bulletMasterR + " ";
        countTR4.text = bulletMasterR + " ";

        if(HandAnimationController.Reloard == true)
        {

            reload.Play();
            HandAnimationController.Reloard = false;

        }
    }

    public void FireGun()
    {

        if(bulletMasterR > 0)
        {
            //Access the animator on the gun model, trigger the
            gunAnimator.SetTrigger("Fire");

            GameObject generatedLaserBeam = Instantiate(LaserBeamModel, LaserSpawnPoint.position, LaserSpawnPoint.rotation);

            Debug.Log("발사~");

            fire.Play();

            //GetComponent<AudioSource>().Play();

            List<UnityEngine.XR.InputDevice> devices = new List<UnityEngine.XR.InputDevice>();

            bulletMasterR--;

            countTR1.text = bulletMasterR + "/10";

            Debug.Log("총알 카운트" + bulletMasterR);
        }
        else
        {
            erro.Play();
            Debug.Log("총알이 없습니다");
        }

        /*
        if (bulletMasterR2 > 0)
        {
            //Access the animator on the gun model, trigger the
            gunAnimator.SetTrigger("Fire");

            GameObject generatedLaserBeam = Instantiate(LaserBeamModel, LaserSpawnPoint.position, LaserSpawnPoint.rotation);

            Debug.Log("발사~");

            GetComponent<AudioSource>().Play();

            List<UnityEngine.XR.InputDevice> devices = new List<UnityEngine.XR.InputDevice>();

            bulletMasterR2--;

            countTR1.text = bulletMasterR2 + "/10";

            Debug.Log("총알 카운트" + bulletMasterR2);
        }
        else
        {
            Debug.Log("총알이 없습니다");
        }

        if (bulletMasterR3 > 0)
        {
            //Access the animator on the gun model, trigger the
            gunAnimator.SetTrigger("Fire");

            GameObject generatedLaserBeam = Instantiate(LaserBeamModel, LaserSpawnPoint.position, LaserSpawnPoint.rotation);

            Debug.Log("발사~");

            GetComponent<AudioSource>().Play();

            List<UnityEngine.XR.InputDevice> devices = new List<UnityEngine.XR.InputDevice>();

            bulletMasterR3--;

            countTR1.text = bulletMasterR3 + "/10";

            Debug.Log("총알 카운트" + bulletMasterR3);
        }
        else
        {
            Debug.Log("총알이 없습니다");
        }
        
         */





    }
}
