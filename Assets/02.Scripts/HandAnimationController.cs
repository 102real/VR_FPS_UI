using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandAnimationController : MonoBehaviour
{
    

    public InputDeviceCharacteristics controllerType;
    public InputDevice thisController;

    private bool isContrillerDetected = false;
    private Animator animatorController;

    static public bool Reloard = false;

    
    void Start()
    {
        Initialise();
        animatorController = GetComponent<Animator>();

        
        
    }

    void Initialise()
    {
        List<InputDevice> controllerDevices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(controllerType, controllerDevices);

        if (controllerDevices.Count.Equals(0))
        {
            Debug.Log("List is empty");
        }
        else
        {
            thisController = controllerDevices[0];

            // Debug.Log(thisController.name);
            isContrillerDetected = true;
        }
    }

    void Update()
    {
        if (!isContrillerDetected)
        {
            Initialise();
        }
        else
        {
            if (thisController.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue) && triggerValue > 0.1f)
            {
                //Debug.Log("TriggerPrass");
                animatorController.SetFloat("Trigger", triggerValue);
            }
            if (thisController.TryGetFeatureValue(CommonUsages.grip, out float gripVallue) && gripVallue > 0.1f)
            {
                //Debug.Log("TriggerPrass" + gripVallue);
                animatorController.SetFloat("Grip", gripVallue);


            }

            if (thisController.TryGetFeatureValue(CommonUsages.primaryButton, out bool button1))
            {
                if(button1)
                {
                    Debug.Log("Button");
                    

                    Reloard = true;
                    


                }


            } 
            
            if (thisController.TryGetFeatureValue(CommonUsages.secondaryButton, out bool button2))
            {
                if(button2)
                {
                    Debug.Log("Button");
                    //FireLaserGun.bulletMasterR = 10;

                    Reloard = true;


                }


            }
        }
        
    }
}
