using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiOnOff : MonoBehaviour
{

    public GameObject vw1;
    public GameObject vw2;
    public GameObject vw3;

    int onf = GameManager.UIONOFF;
    // Update is called once per frame
    void Update()
    {
        int onf = GameManager.UIONOFF;
        if (onf == 1)
        {
            vw1.SetActive(false);
            vw2.SetActive(false);
            vw3.SetActive(true);
        }
        else if(onf == 0)
        {
            vw1.SetActive(true);
            vw2.SetActive(true);
            vw3.SetActive(false);
        }
    }
}
