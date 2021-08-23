using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandAnimationController : MonoBehaviour
{
    public InputDeviceCharacteristics controllerType;
    public InputDevice thisController;

    private bool isContrillerDetected = false;
    void Start()
    {
        Initialise();
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
                Debug.Log("TriggerPrass");
            }
            if (thisController.TryGetFeatureValue(CommonUsages.grip, out float gripVallue) && gripVallue > 0.1f)
            {
                Debug.Log("TriggerPrass" + gripVallue);

            }
        }
        
    }
}
